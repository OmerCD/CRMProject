using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CRMKurs.Attributes;
using DesktopAppCRM;
using MySql.Data.MySqlClient;

namespace CRMKurs.CustomTools
{

    public partial class PropertyGridMVCList : UserControl
    {
        private object _selectedTable;
        private object _selectedObject;
        private Type _tableType;
        private Dictionary<string, Control> _valueControls = new Dictionary<string, Control>();
        List<string> _idList = new List<string>();
        private List<string> _alanlar;
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
                _tableType = _selectedTable.GetType();
                if (value != null)
                {
                    RefreshTableValues();
                }
            }
        }

        private void RefreshTableValues()
        {
            string indexName;
            lVTableValues.Items.Clear();
            lVTableValues.Columns.Clear();
            SelectedObject = _selectedTable;
            _tableType = _selectedTable.GetType();
            var tableQuery = CreateTableQuery(out indexName);
            DBConnection.QueryConnection.Open();
            LoadListView(indexName, tableQuery);
            var extraFieldController = new ExtraFieldController(_selectedObject);
            if (extraFieldController.Exists)
            {
                
            }
        }

        private void LoadListView(string indexName, string tableQuery)
        {
            using (var cmd = new MySqlCommand(tableQuery, DBConnection.QueryConnection))
            {
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        if (!rd.HasRows) continue;
                        _idList.Add(rd[indexName].ToString());
                        var lv = new ListViewItem()
                        {
                            Text = rd[_alanlar[0]].ToString()
                        };

                        //satırın ilk değeri text olmayınca olmuyo
                        for (var i = 1; i < _alanlar.Count; i++)
                        {
                            var field = rd[_alanlar[i]].ToString();
                            lv.SubItems.Add(field).Text = field;
                        }
                        lVTableValues.Items.Add(lv);
                    }
                }
            }
            DBConnection.QueryConnection.Close();
        }

        private string CreateTableQuery(out string indexName)
        {
            indexName = "";
            var tableQuery = "SELECT ";
            var dizi = _tableType.GetProperties();
            var entityFields = new List<string>();
            var entityFieldsForJoin = new List<string>();
            _alanlar = new List<string>();
            foreach (var property in dizi)
            {
                var customAttributes = property.CustomAttributes;
                var attributeDatas = customAttributes as CustomAttributeData[] ?? customAttributes.ToArray();
                if (!attributeDatas.Any()) continue;
                if (attributeDatas.Any(x => x.AttributeType == typeof(KeyAttribute)))
                {
                    indexName = property.Name;
                    tableQuery += _tableType.Name + "." + indexName + " ,";
                    continue;
                }
                var customAttribute = property.GetCustomAttribute<PropertyMVC>();
                if (customAttribute == null) continue;
                var deger = property.Name;
                lVTableValues.Columns.Add(customAttribute.DisplayName).Name = customAttribute.DisplayName;
                if (customAttribute.DesiredControl == ControlEnum.Entity)
                {
                    entityFields.Add(deger);
                    entityFieldsForJoin.Add(deger + "_Id");
                    _alanlar.Add(deger);
                    deger += ".Isim AS " + deger;
                }
                else
                {
                    _alanlar.Add(deger);
                    deger = _tableType.Name + "." + deger;
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
            for (var i = 0; i < entityFields.Count; i++)
            {
                tableQuery += " INNER JOIN " + entityFields[i] + " ON " + _tableType.Name + "." + entityFieldsForJoin[i] +
                              " = " + entityFields[i] + ".Id ";
            }
            tableQuery += " WHERE " + _tableType.Name + ".OwnerId = " + DataBaseConnectionOptions.OwnerUserId;
            return tableQuery;
        }

        protected object GetForeignKeyField(PropertyInfo property, string idValue)
        {
            return DBConnection.DbCon.Set(property.PropertyType).Find(idValue);
        }
        private void AssignValues()
        {
            _selectedObject = Activator.CreateInstance(_selectedObject.GetType());
            var props = _selectedObject.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.CustomAttributes.All(data => data.AttributeType != typeof(PropertyMVC))) continue;
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
        public PropertyGridMVCList()
        {
            InitializeComponent();
        }

        private void CreateFields()
        {
            panelPropArea.Controls.Clear();
            _valueControls = new Dictionary<string, Control>();
            var objType = _selectedObject.GetType();
            var props = objType.GetProperties();
            int x = 80, y = 5;
            var difference = 30;
            foreach (var prop in props)
            {
                var extraArea = false;
                var attr = prop.GetCustomAttribute<PropertyMVC>();
                if (attr == null) continue;
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
                        var cbx = new DataComboBox();
                        requiredControl = GetRequiredCombobox(propQuery, cbx);
                        break;
                    default:
                        requiredControl = GetControl(attribute.DesiredControl, attribute.Source);
                        break;
                }
                if (requiredControl == null) continue;
                var propValue = prop.GetValue(_selectedObject);
                var lbl = new Label
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

        private Control GetRequiredCombobox(string propertyQuery, DataComboBox dataComboBox)
        {
            DBConnection.QueryConnection.Open();
            using (var cmd = new MySqlCommand(propertyQuery, DBConnection.QueryConnection))
            {
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        if (!rd.HasRows) continue;
                        dataComboBox.Items.Add(rd[1]);
                        dataComboBox.RealValues.Add(rd[0].ToString());
                    }
                }
            }
            DBConnection.QueryConnection.Close();
            if (dataComboBox.Items.Count != 0)
            {
                dataComboBox.SelectedIndex = 0;
            }
            return dataComboBox;
        }

        public object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        private Control GetControl(ControlEnum cEnum, params object[] sourceObjects)
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
            }
            return null;
        }
        Control GetControl(ControlEnum cEnum, object selection, params object[] sourceObjects)
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
                    tempC.SelectedItem = selection;
                    return tempC;
                case ControlEnum.NumericUpDown:
                    return new NumericUpDown();
                case ControlEnum.DateTime:
                    break;
            }
            return null;
        }

        private void lVTableValues_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lVTableValues.SelectedIndices.Count == 0)
            {
                return;
            }
            var lv = lVTableValues.SelectedItems[0];
            ControlDesigner(lv);
        }

        private void ControlDesigner(ListViewItem lv)
        {
            var c = 0;
            foreach (Control control in panelPropArea.Controls)
            {
                if (control is Label) continue;
                if (control is TextBox)
                {
                    control.Text = lv.SubItems[c].Text;
                }
                else if (control is DataComboBox)
                {
                    var cbx = control as DataComboBox;
                    foreach (var cbxItem in cbx.Items)
                    {
                        if (cbxItem.ToString() != lv.SubItems[c].Text) continue;
                        cbx.SelectedItem = cbxItem;
                        break;
                    }
                }
                else if (control is ComboBox)
                {
                    var cbx = control as ComboBox;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var toAddObject = SelectedObject;
            var type = toAddObject.GetType();
            DBConnection.DbCon.Set(type).Add(toAddObject);
            var message = DBConnection.SaveChanges();
            if (message != "") MessageBox.Show(message);
            RefreshTableValues();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lVTableValues.SelectedIndices.Count == 0) return;
            var toAddObject = SelectedObject;
            var type = toAddObject.GetType();
            EditEntity(toAddObject, type);
            RefreshTableValues();
        }
        private void EditEntity(object toAddObject, Type type)
        {
            var idProp = type.GetProperty("Id");
            var idValue = _idList[lVTableValues.SelectedIndices[0]];
            idProp.SetValue(toAddObject, idValue);
            var dbSet = DBConnection.DbCon.Set(type);
            var foundObject = dbSet.Find(idValue);
            var findResult = DBConnection.DbCon.Entry(foundObject);
            var currentValues = findResult.CurrentValues;
            currentValues.SetValues(toAddObject);
            var message = DBConnection.SaveChanges();
            if (message != "") MessageBox.Show(message);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lVTableValues.SelectedIndices.Count == 0) return;
            var toRemoveObject = SelectedObject;
            DeleteEntity(toRemoveObject);
            RefreshTableValues();
        }

        private void DeleteEntity(object toRemoveObject)
        {
            var type = toRemoveObject.GetType();
            var idValue = _idList[lVTableValues.SelectedIndices[0]];
            var foundObject = DBConnection.DbCon.Set(type).Find(idValue);
            DBConnection.DbCon.Set(type).Remove(foundObject);
            var message = DBConnection.SaveChanges();
            if (message != "") MessageBox.Show(message);
        }
    }

    internal class IdNotFoundException : Exception
    {

    }
}
