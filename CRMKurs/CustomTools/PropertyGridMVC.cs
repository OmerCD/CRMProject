﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CRMKurs.Attributes;
using MySql.Data.MySqlClient;

namespace CRMKurs.CustomTools
{

    public partial class PropertyGridMVC : UserControl
    {
        private object _selectedObject;
        Dictionary<string, Control> _valueControls = new Dictionary<string, Control>();
        public object SelectedObject
        {
            get
            {
                AssignValues();
                return _selectedObject;
            }
            set
            {
                _selectedObject = value;
                if (value != null)
                {
                    CreateFields();
                }
            }
        }

        object GetForeignKeyField(PropertyInfo property, string idValue)
        {
            //object classInstance = Activator.CreateInstance(property.PropertyType);
            //var propQuery = GetPropValue(DBConnection.DbCon, property.PropertyType.Name) + " Where Id = " + idValue;
            //DBConnection.QueryConnection.Open();
            //using (MySqlCommand cmd = new MySqlCommand(propQuery, DBConnection.QueryConnection))
            //{
            //    using (MySqlDataReader rd = cmd.ExecuteReader())
            //    {
            //        while (rd.Read())
            //        {
            //            if (!rd.HasRows) continue;
            //            var instancePorperties = classInstance.GetType().GetProperties();
            //            foreach (var instancePorperty in instancePorperties)
            //            {
            //                instancePorperty.SetValue(classInstance, rd[instancePorperty.Name].ToString());
            //            }
            //            break;
            //        }
            //    }
            //}
            //DBConnection.QueryConnection.Close();
            return DBConnection.DbCon.Set(property.PropertyType).Find(idValue);
        }
        private void AssignValues()
        {
            var props = _selectedObject.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.CustomAttributes.Any(data => data.AttributeType == typeof(PropertyMVC)))
                {
                    var value = _valueControls[prop.Name].Text;
                    if (prop.GetCustomAttribute<PropertyMVC>().DesiredControl == ControlEnum.Entity)
                    {
                        var foreignObject = GetForeignKeyField(prop, ((DataComboBox)_valueControls[prop.Name]).GetSelectedValue);
                        prop.SetValue(_selectedObject, foreignObject);
                    }
                    else
                    {
                        prop.SetValue(_selectedObject, value);
                    }
                }
            }
        }

        public PropertyGridMVC()
        {
            InitializeComponent();
        }
        string[] TakeFieldNames(string query)
        {
            var returnValues = new List<string>();
            var splitQuery = query.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 1; i < splitQuery.Length; i++)
            {
                if (splitQuery[i].StartsWith("`Extent"))
                {
                    returnValues.Add(splitQuery[i].Split('.')[1].Replace("`, ", "").Replace("`", ""));
                }
            }

            return returnValues.ToArray();
        }
        void CreateFields()
        {
            panelPropArea.Controls.Clear();
            _valueControls = new Dictionary<string, Control>();
            var objType = _selectedObject.GetType();
            var props = objType.GetProperties();
            int x = 80, y = 5;
            var difference = 30;
            //var tableQuery = GetPropValue(DBConnection.DbCon, objType.Name).ToString(); //  verilen tabloyu almak için query'i veriyor

            foreach (var prop in props)
            {
                var extraArea = false;
                var attribute = prop.GetCustomAttribute<PropertyMVC>();
                if (attribute == null) continue;
                Control requiredControl = null;
                switch (attribute.DesiredControl)
                {
                    case ControlEnum.MultilineTextBox:
                        requiredControl = new TextBox { Multiline = true };
                        extraArea = true;
                        break;
                    case ControlEnum.MultipleAdder:

                        break;
                    case ControlEnum.Entity: // Entity id veya class ataması yapılacak
                        var propQuery = GetPropValue(DBConnection.DbCon, prop.PropertyType.Name);
                            
                        //var fieldNames = TakeFieldNames(propQuery);
                        var cbx = new DataComboBox();
                        #region Düzenleme için bilgi getirme kodu
                        DBConnection.QueryConnection.Open();
                        using (var cmd = new MySqlCommand(propQuery.ToString(), DBConnection.QueryConnection))
                        {
                            using (var rd = cmd.ExecuteReader())
                            {
                                while (rd.Read())
                                {
                                    if (!rd.HasRows) continue;
                                    cbx.Items.Add(rd[1]);
                                    cbx.RealValues.Add(rd[0].ToString());
                                }
                            }
                        }
                        DBConnection.QueryConnection.Close();
                        if (cbx.Items.Count != 0)
                        {
                            cbx.SelectedIndex = 0;
                        }
                        requiredControl = cbx;
                        #endregion
                        break;
                    default:

                        requiredControl = GetControl(attribute.DesiredControl, attribute.Source);

                        break;
                }
                if (requiredControl != null)
                {
                    //prop.SetValue(SelectedObject, "Test");
                    var propValue = prop.GetValue(_selectedObject);
                    var lbl = new System.Windows.Forms.Label
                    {
                        Text = attribute.DisplayName,
                        Location = new Point(0, y),
                        AutoSize = true
                    };
                    requiredControl.Size = new Size(150, 25);
                    requiredControl.Location = new Point(x, y);
                    if (propValue != null) requiredControl.Text = propValue.ToString();
                    y += extraArea ? difference + 5 : difference;
                    extraArea = false;
                    panelPropArea.Controls.Add(lbl);
                    panelPropArea.Controls.Add(requiredControl);
                    _valueControls.Add(prop.Name, requiredControl);
                }
            }
        }
        public object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src);
        }
        Control GetControl(ControlEnum cEnum, params object[] sourceObjects)
        {
            switch (cEnum)
            {
                case ControlEnum.TextBox:
                    return new TextBox();
                case ControlEnum.Combobox:
                    var tempC = new ComboBox();

                    if (sourceObjects != null && sourceObjects.Length > 0)
                    {
                        tempC.Items.AddRange(sourceObjects);
                        tempC.SelectedIndex = 0;
                    }
                    return tempC;
                case ControlEnum.NumericUpDown:
                    return new NumericUpDown();
                case ControlEnum.DateTime:
                    break;
                default:
                    break;
            }
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var testValue = SelectedObject;
        }
    }
}
