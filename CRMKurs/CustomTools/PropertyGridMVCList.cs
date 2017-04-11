using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private Type _tableType;
        Dictionary<string, Control> _valueControls = new Dictionary<string, Control>();
        List<string> _idList = new List<string>();
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
            string indexName="";
            lVTableValues.Items.Clear();
            SelectedObject = _selectedTable;
            _tableType = _selectedTable.GetType();
            var tableQuery = "SELECT ";
            var dizi = _tableType.GetProperties();
            var entityFields = new List<string>();
            var entityFieldsForJoin = new List<string>();
            List<string> alanlar = new List<string>();
            foreach (PropertyInfo property in dizi)
            {
                var customAttributes = property.CustomAttributes;
                var attributeDatas = customAttributes as CustomAttributeData[] ?? customAttributes.ToArray();
                if(!attributeDatas.Any()) continue;
                if (attributeDatas.Any(x => x.AttributeType == typeof(KeyAttribute)))
                {
                    indexName = property.Name;
                    tableQuery += _tableType.Name + "." + indexName + " ,";
                    continue;
                }
                
                if (property.GetCustomAttribute<PropertyMVC>() == null) continue;
                string deger = property.Name;
                lVTableValues.Columns.Add(deger).Name = deger;
                if (property.GetCustomAttribute<PropertyMVC>().DesiredControl == ControlEnum.Entity)
                {
                    entityFields.Add(deger);
                    entityFieldsForJoin.Add(deger + "_Id");
                    alanlar.Add(deger);
                    deger += ".Isim AS "+deger;
                }
                else
                {
                    alanlar.Add(deger);
                    deger = _tableType.Name+"." + deger;
                }
                tableQuery += deger + " ";
                
                tableQuery += ",";
            }
            if (string.IsNullOrEmpty(indexName))
            {
                throw new IdNotFoundException();
            }
            tableQuery = tableQuery.Substring(0, tableQuery.Length - 1);
            tableQuery += " FROM ";
            tableQuery += _tableType.Name;
            for (int i = 0; i < entityFields.Count; i++)
            {
                tableQuery += " INNER JOIN " + entityFields[i] + " ON " + _tableType.Name + "." + entityFieldsForJoin[i] +
                              " = " + entityFields[i] + ".Id ";
            }
            tableQuery += " WHERE " + _tableType.Name+".OwnerId = " + DataBaseConnectionOptions.OwnerUserId;


            MessageBox.Show(tableQuery);
            DBConnection.QueryConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(tableQuery, DBConnection.QueryConnection))
            {
                using (MySqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        if (!rd.HasRows) continue;
                        _idList.Add(rd[indexName].ToString());
                        ListViewItem lv = new ListViewItem()
                        {
                            Text = rd[alanlar[0]].ToString()
                        };

                        //satırın ilk değeri text olmayınca olmuyo
                        for (int i = 1; i < alanlar.Count; i++)
                        {
                            string field = rd[alanlar[i]].ToString();
                            lv.SubItems.Add(field).Text = field;
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
                var testAttr = prop.CustomAttributes;
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
                var attr = prop.GetCustomAttribute<PropertyMVC>();
                //var attr = prop.GetCustomAttributes(typeof(PropertyMVC), false);
                if (attr != null)
                {
                    Control requiredControl = null;

                    var attribute = attr;
                    switch (attribute.DesiredControl)
                    {
                        case ControlEnum.MultilineTextBox:
                            requiredControl = new TextBox { Multiline = true };
                            extraArea = true;
                            break;
                        case ControlEnum.MultipleAdder:

                            break;
                        case ControlEnum.Entity:
                            var propQuery = GetPropValue(DBConnection.DbCon, prop.PropertyType.Name).ToString();
                            //var fieldNames = TakeFieldNames(propQuery);
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
                    if (requiredControl == null) continue;
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
        private void lVTableValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            var props = _tableType.GetProperties();
            var query = GetPropValue(DBConnection.DbCon, _tableType.Name);
            int c = 0;
            if (lVTableValues.SelectedIndices.Count==0)
            {
                return;
            }
            ListViewItem lv = lVTableValues.SelectedItems[0];

            foreach (Control control in panelPropArea.Controls)
            {
                if (!(control is System.Windows.Forms.Label))
                {
                    if (control is TextBox)
                    {
                        control.Text = lv.SubItems[c].Text; 
                    }
                    else if (control is DataComboBox)
                    {
                        DataComboBox cbx = control as DataComboBox;
                        //cbx.SelectedIndex = cbx.RealValues.IndexOf(_idList[lv.Index]);
                        foreach (var cbxItem in cbx.Items)
                        {
                            if (cbxItem.ToString() != lv.SubItems[c].Text) continue;
                            cbx.SelectedItem = cbxItem;
                            break;
                        }
                    }
                    c++;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }

    internal class IdNotFoundException : Exception
    {

    }
}
