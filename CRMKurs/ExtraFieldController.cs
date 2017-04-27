using System.Linq;
using System.Reflection;
using CRMKurs.Attributes;
using DesktopAppCRM;
using MySql.Data.MySqlClient;

namespace CRMKurs
{
    class ExtraFieldController
    {
        public ExtraFieldController(object toCheckObject)
        {
            Exists = false;
            var objectType = toCheckObject.GetType();
            var property = objectType.GetProperties().First(x => x.GetCustomAttribute<ExtraFieldSeperator>() != null);
            if (property == null) return;
            string query = $"Select Id From Owner{DataBaseConnectionOptions.OwnerUserId} Where TabloAdi = '{objectType.Name}' and AlanAdi = ";
            query += FindFieldName(toCheckObject, property);
            Exists = CheckIfExists(query);
        }
        private bool CheckIfExists(string query)
        {
            DBConnection.QueryConnection.Open();
            using (var cmd = new MySqlCommand(query, DBConnection.QueryConnection))
            {
                if (cmd.ExecuteScalar() != null)
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
    }
}
