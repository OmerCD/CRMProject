using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppCRM;
using MySql.Data.MySqlClient;

namespace CRMKurs.CustomTools
{

    public partial class PropertyGridMVCList : UserControl
    {
        private object _selectedTable;
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

        public object SelectedTable
        {
            set
            {
                _selectedTable = value;
                if (value != null)
                {
                    RefreshTableValues();
                }
            }
        }

        private void RefreshTableValues()
        {
            lVTableValues.Items.Clear();
            var test = _selectedTable;
            var tableType = _selectedTable.GetType();
            var tableName = tableType.Name;
            var tableQuery = "SELECT ";
            var dizi = tableType.GetProperties();
            List<string> alanlar = new List<string>();
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].CustomAttributes.Any(data => data.AttributeType == typeof(PropertyMVC)))
                {
                    string deger = dizi[i].Name;
                    tableQuery += deger + " ";
                    lVTableValues.Columns.Add(deger);
                    alanlar.Add(deger);
                    tableQuery += ",";
                }
            }
            tableQuery = tableQuery.Substring(0, tableQuery.Length - 1);
            tableQuery += " FROM ";
            tableQuery += tableType.Name;
            tableQuery += " WHERE OwnerId = " + DataBaseConnectionOptions.OwnerUserId;
            var propQuery = GetPropValue(DBConnection.DbCon, _selectedTable.GetType().Name).ToString();



            DBConnection.QueryConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(tableQuery, DBConnection.QueryConnection))
            {
                using (MySqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        if (!rd.HasRows) continue;
                        ListViewItem lv = new ListViewItem();
                        lv.Text = rd[alanlar[0]].ToString();  //satırın ilk değeri text olmayınca olmuyo
                        for (int i = 1; i < alanlar.Count; i++)
                        {
                            string Field = rd[alanlar[i]].ToString();
                            lv.SubItems.Add(Field);
                        }
                        lVTableValues.Items.Add(lv);
                    }
                }
            }
            DBConnection.QueryConnection.Close();
        }

        object GetForeignKeyField(PropertyInfo property, string idValue)
        {
            object classInstance = Activator.CreateInstance(property.PropertyType);
            var propQuery = GetPropValue(DBConnection.DbCon, property.PropertyType.Name).ToString();
            DBConnection.QueryConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(propQuery, DBConnection.QueryConnection))
            {
                using (MySqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        if (!rd.HasRows) continue;
                        string idField = rd["Id"].ToString();
                        if (idField != idValue) continue;

                        var instancePorperties = classInstance.GetType().GetProperties();
                        foreach (var instancePorperty in instancePorperties)
                        {
                            instancePorperty.SetValue(classInstance, rd[instancePorperty.Name].ToString());
                        }
                        break;
                    }
                }
            }
            DBConnection.QueryConnection.Close();
            return classInstance;
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

        public PropertyGridMVCList()
        {
            InitializeComponent();
        }
        string[] TakeFieldNames(string query)
        {
            List<string> returnValues = new List<string>();
            string[] splitQuery = query.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < splitQuery.Length; i++)
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
            Type objType = _selectedObject.GetType();
            var props = objType.GetProperties();
            int x = 80, y = 5;
            int difference = 30;
            //var tableQuery = GetPropValue(DBConnection.DbCon, objType.Name).ToString(); //  verilen tabloyu almak için query'i veriyor

            foreach (var prop in props)
            {
                bool extraArea = false;
                var attr = prop.GetCustomAttributes(typeof(PropertyMVC), false);
                if (attr.Length != 0)
                {
                    Control requiredControl = null;

                    var attribute = (PropertyMVC)attr[0];
                    switch (attribute.DesiredControl)
                    {
                        case ControlEnum.MultilineTextBox:
                            requiredControl = new TextBox { Multiline = true };
                            extraArea = true;
                            break;
                        case ControlEnum.MultipleAdder:

                            break;
                        case ControlEnum.Entity: // Entity id veya class ataması yapılacak
                            var propQuery = GetPropValue(DBConnection.DbCon, prop.PropertyType.Name).ToString();
                            var fieldNames = TakeFieldNames(propQuery);
                            DataComboBox cbx = new DataComboBox();
                            #region Düzenleme için bilgi getirme kodu
                            DBConnection.QueryConnection.Open();
                            using (MySqlCommand cmd = new MySqlCommand(propQuery, DBConnection.QueryConnection))
                            {
                                using (MySqlDataReader rd = cmd.ExecuteReader())
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
                        string propName = prop.Name;
                        //prop.SetValue(SelectedObject, "Test");
                        var propValue = prop.GetValue(_selectedObject);
                        var lbl = new System.Windows.Forms.Label
                        {
                            Text = propName,
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
        }
        public object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
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
