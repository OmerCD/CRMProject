using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
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
        private string _tableQuery;
        Dictionary<string, Control> _valueControls = new Dictionary<string, Control>();
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
                    //CreateTableColumns();
                    RefreshTableValues();
                    //ListViewFill();
                }
            }
        }

        private void CreateTableColumns()
        {
            SelectedObject = _selectedTable;
            var properties = _selectedTable.GetType().GetProperties();
            foreach (var property in properties)
            {
                var attribute = property.GetCustomAttribute<PropertyMVC>();
                if (attribute != null)
                {
                    lVTableValues.Columns.Add(attribute.DisplayName);
                }
            }
        }
        private void RefreshTableValues()
        {
            string indexName = "";
            lVTableValues.Items.Clear();
            lVTableValues.Columns.Clear();
            SelectedObject = _selectedTable;
            _tableType = _selectedTable.GetType();
            var tableQuery = "SELECT ";
            var dizi = _tableType.GetProperties();
            var entityFields = new List<string>();
            var entityFieldsForJoin = new List<string>();
            _alanlar = new List<string>();
            foreach (PropertyInfo property in dizi)
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

                if (property.GetCustomAttribute<PropertyMVC>() == null) continue;
                string deger = property.Name;
                lVTableValues.Columns.Add(deger).Name = deger;
                if (property.GetCustomAttribute<PropertyMVC>().DesiredControl == ControlEnum.Entity)
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
            for (int i = 0; i < entityFields.Count; i++)
            {
                tableQuery += " INNER JOIN " + entityFields[i] + " ON " + _tableType.Name + "." + entityFieldsForJoin[i] +
                              " = " + entityFields[i] + ".Id ";
            }
            tableQuery += " WHERE " + _tableType.Name + ".OwnerId = " + DataBaseConnectionOptions.OwnerUserId;
            _tableQuery = tableQuery;

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
                            Text = rd[_alanlar[0]].ToString()
                        };

                        //satırın ilk değeri text olmayınca olmuyo
                        for (int i = 1; i < _alanlar.Count; i++)
                        {
                            string field = rd[_alanlar[i]].ToString();
                            lv.SubItems.Add(field).Text = field;
                        }
                        lVTableValues.Items.Add(lv);
                    }
                }
            }
            DBConnection.QueryConnection.Close();
        }

        private ListViewItem GetListViewItem(object instance)
        {
            var instanceType = instance.GetType();
            var instanceProperties = instanceType.GetProperties();
            ListViewItem lv = new ListViewItem();
            foreach (PropertyInfo property in instanceProperties)
            {
                switch (property.Name)
                {
                    case "Isim":
                        lv.Text = property.GetValue(instance).ToString();
                        continue;
                    case "Id":
                        continue;
                }
                lv.SubItems.Add(property.GetValue(instance).ToString());
            }
            return lv;
        }
        private void ListViewFill()
        {
            _idList.Clear();
            //var dizi = _tableType.GetProperties();
            lVTableValues.Items.Clear();
            //lVTableValues.Columns.Clear();
            //List<string> alanlar = new List<string>();
            //foreach (PropertyInfo property in dizi)
            //{
            //    if (property.GetCustomAttribute<PropertyMVC>() == null) continue;
            //    string deger = property.Name;
            //    lVTableValues.Columns.Add(deger).Name = deger;
            //    alanlar.Add(deger);
            //}
            string tableQuery = "Select * From " + _tableType.Name + " Where OwnerId = '" + DataBaseConnectionOptions.OwnerUserId + "'";
            var dBSet = DBConnection.DbCon.Set(_selectedObject.GetType()).SqlQuery(tableQuery);
            foreach (var field in dBSet)
            {
                Type tableType = field.GetType();
                var properties = tableType.GetProperties();
                _idList.Add(properties.First(x => x.Name == "Id").GetValue(field).ToString());
                ListViewItem lv = new ListViewItem
                {
                    Text = properties.First(x => x.Name == "Isim").GetValue(field).ToString()
                };
                for (int i = 0; i < properties.Length; i++)
                {
                    if (properties[i].Name == "Isim" || properties[i].Name == "Id") continue;
                    var attribute = properties[i].GetCustomAttribute<PropertyMVC>();
                    if (attribute == null) continue;
                    if (attribute.DesiredControl == ControlEnum.Entity)
                    {
                        try
                        {
                            var entityField = properties[i].GetValue(field);
                            var test = entityField.GetType().GetProperty("Isim").GetValue(entityField);
                            lv.SubItems.Add(test.ToString());
                        }
                        catch (System.Reflection.TargetInvocationException ex)
                        {
                            //var entityType = properties[i].PropertyType;
                            //string query = "Select " + entityType.Name + ".Isim From " + entityType.Name +
                            //               " Inner Join " +
                            //               // ReSharper disable once PossibleNullReferenceException
                            //               tableType.BaseType.Name + " on " + tableType.BaseType.Name + "." + entityType.Name + "_Id = " + entityType.Name + ".Id" +
                            //               " Where "+entityType.Name+".OwnerId =" + DataBaseConnectionOptions.OwnerUserId;
                            //var selectedSet = DBConnection.DbCon.Set(entityType).SqlQuery(query);
                            //foreach (var selection in selectedSet)
                            //{

                            //}
                        }
                        continue;
                    }
                    lv.SubItems.Add(properties[i].GetValue(field).ToString());
                }
                lVTableValues.Items.Add(lv);
            }
            //DBConnection.QueryConnection.Open();
            //using (MySqlCommand cmd = new MySqlCommand(_tableQuery, DBConnection.QueryConnection))
            //{
            //    using (MySqlDataReader rd = cmd.ExecuteReader())
            //    {
            //        while (rd.Read())
            //        {
            //            if (!rd.HasRows) continue;
            //            _idList.Add(rd["Id"].ToString());
            //            ListViewItem lv = new ListViewItem()
            //            {
            //                Text = rd[alanlar[0]].ToString()
            //            };

            //            //satırın ilk değeri text olmayınca olmuyo
            //            for (int i = 1; i < alanlar.Count; i++)
            //            {
            //                string field = rd[alanlar[i]].ToString();
            //                lv.SubItems.Add(field).Text = field;
            //            }
            //            lVTableValues.Items.Add(lv);
            //        }
            //    }
            //}
            //DBConnection.QueryConnection.Close();
        }
        object GetForeignKeyField(PropertyInfo property, string idValue)
        {
            return DBConnection.DbCon.Set(property.PropertyType).Find(idValue);
        }
        private void AssignValues()
        {
            _selectedObject = Activator.CreateInstance(_selectedObject.GetType());
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
                var attr = prop.GetCustomAttribute<PropertyMVC>();
                //var attr = prop.GetCustomAttributes(typeof(PropertyMVC), false);
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
                    //case ControlEnum.Combobox:
                    //    requiredControl = GetControl(ControlEnum.Combobox, prop.GetValue(SelectedObject),
                    //        attribute.Source);
                    //    break;
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
            int c = 0;
            if (lVTableValues.SelectedIndices.Count == 0)
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
                    else if (control is ComboBox)
                    {
                        ComboBox cbx = control as ComboBox;
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
            object toAddObject = SelectedObject;
            var type = toAddObject.GetType();
            DBConnection.DbCon.Set(type).Add(toAddObject);
            var message = DBConnection.SaveChanges();
            if (message != "") MessageBox.Show(message);
            RefreshTableValues();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lVTableValues.SelectedIndices.Count == 0) return;
            object toAddObject = SelectedObject;
            Type type = toAddObject.GetType();
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
            RefreshTableValues();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lVTableValues.SelectedIndices.Count == 0) return;
            object toRemoveObject = SelectedObject;
            Type type = toRemoveObject.GetType();
            var idValue = _idList[lVTableValues.SelectedIndices[0]];
            var foundObject = DBConnection.DbCon.Set(type).Find(idValue);
            DBConnection.DbCon.Set(type).Remove(foundObject);
            var message = DBConnection.SaveChanges();
            if (message != "") MessageBox.Show(message);
            RefreshTableValues();
        }
    }

    internal class IdNotFoundException : Exception
    {

    }
}
