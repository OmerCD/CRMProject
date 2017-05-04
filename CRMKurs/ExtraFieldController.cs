using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using CRMKurs.Attributes;
using DesktopAppCRM;
using MySql.Data.MySqlClient;

namespace CRMKurs
{
    internal class ExtraFieldController
    {
        private readonly object _toCheckObject;
        private readonly Dictionary<string, string> _fields;
        private readonly string _fieldName;

        public ExtraFieldController(object toCheckObject)
        {
            _toCheckObject = toCheckObject;
            _fields = new Dictionary<string, string>();
            Exists = false;
            var objectType = toCheckObject.GetType();
            var extraFieldProperty = objectType.GetProperties().FirstOrDefault(x => x.GetCustomAttribute<ExtraFieldSeperator>() != null);
            if (extraFieldProperty == null) return;
            _fieldName = FindFieldName(toCheckObject, extraFieldProperty);
            var typeName = objectType.Name;
            if (objectType.Namespace == "System.Data.Entity.DynamicProxies")
            {
                typeName = objectType.BaseType?.Name;
            }
            var query = $"Select DegerTabloAdi From Owner{DataBaseConnectionOptions.OwnerUserId} Where TabloAdi = '{typeName}' and AlanAdi = " + _fieldName;
            Exists = CheckIfExists(query);
        }
        private bool CheckIfExists(string query)
        {
            DBConnection.QueryConnection.Open();
            using (var cmd = new MySqlCommand(query, DBConnection.QueryConnection))
            {
                var dbObject = cmd.ExecuteScalar();
                if (!string.IsNullOrEmpty(dbObject?.ToString()))
                {
                    DBConnection.QueryConnection.Close();
                    return true;
                }
            }
            DBConnection.QueryConnection.Close();
            return false;
        }
        private string FindFieldName(object objectToCheck, PropertyInfo property)
        {
            return property.GetCustomAttribute<PropertyMVC>().DesiredControl != ControlEnum.Entity ? $"'{property.GetValue(objectToCheck)}'" : $"'{GetDisplayName(objectToCheck, property)}'";
        }
        private string GetDisplayName(object objectToCheck, PropertyInfo property)
        {
            var entityObject = property.GetValue(objectToCheck);
            var entityDisplayProperty = entityObject.GetType()
                .GetProperties()
                .First(x => x.GetCustomAttribute<DisplayProperty>() != null);
            var displayName = entityDisplayProperty.GetValue(entityObject).ToString();
            return displayName;
        }
        public bool Exists { get; set; }

        public bool AddValue(string value, string id, string valueName)
        {
            var query = $"Insert Into {valueName + "_" + DataBaseConnectionOptions.OwnerUserId} VALUES (@value,@id)";
            DBConnection.QueryConnection.Open();
            using (var cmd = new MySqlCommand(query, DBConnection.QueryConnection))
            {
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@id", id);
                var returnValue = cmd.ExecuteNonQuery() > 0;
                DBConnection.QueryConnection.Close();
                return returnValue;
            }
        }
        public Dictionary<string, string> Fields
        {
            get
            {
                _fields.Clear();
                DBConnection.QueryConnection.Open();
                var query =
                    $"Select DegerTabloAdi, VeriTuru From Owner{DataBaseConnectionOptions.OwnerUserId} Where TabloAdi = '{_toCheckObject.GetType().Name}' and AlanAdi = " +
                    _fieldName;
                using (var cmd = new MySqlCommand(query, DBConnection.QueryConnection))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _fields.Add(dr[0].ToString(), dr[1].ToString());
                        }
                    }
                }
                DBConnection.QueryConnection.Close();
                return _fields;
            }
        }
        public Dictionary<string, string> FieldsWithValues(string id)
        {
            _fields.Clear();
            var ownerTable = "Owner" + DataBaseConnectionOptions.OwnerUserId;
            DBConnection.QueryConnection.Open();
            var query =
                $"Select {ownerTable}.DegerTabloAdi From {ownerTable} Where {ownerTable}.TabloAdi = '{_toCheckObject.GetType().Name}' and {ownerTable}.AlanAdi = " +
                _fieldName;
            using (var cmd = new MySqlCommand(query, DBConnection.QueryConnection))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _fields.Add(dr[0].ToString(), "");
                    }
                }
            }
            foreach (var field in _fields)
            {
                query = $"Select Value From {field.Key} where ForeignId = {id}";
                _fields[field.Key] = "ASSA"; // Kalınan nokta. Keylere value ataması yapılacak.
            }
            DBConnection.QueryConnection.Close();
            return _fields;
        }
    }
}
