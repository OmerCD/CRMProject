using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRMKurs.CustomTools
{

    public partial class PropertyGridMVC : UserControl
    {
        private object _selectedObject;
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
                if (value!=null)
                {
                    Test();
                }
            }
        }

        private void AssignValues()
        {
            throw new NotImplementedException();
        }

        public PropertyGridMVC()
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
        void Test()
        {
            Type objType = _selectedObject.GetType();
            var props = objType.GetProperties();
            int x = 45, y = 5;
            int difference = 30;
            //var tableQuery = GetPropValue(DBConnection.DbCon, objType.Name).ToString(); //  verilen tabloyu almak için query'i veriyor

            foreach (var prop in props)
            {
                var attr = prop.GetCustomAttributes(typeof(PropertyMVC), false);
                if (attr.Length != 0)
                {
                    Control requiredControl = null;

                    var attribute = (PropertyMVC)attr[0];
                    switch (attribute.DesiredControl)
                    {
                        case ControlEnum.MultipleAdder:

                            break;
                        case ControlEnum.Entity:
                            var propQuery = GetPropValue(DBConnection.DbCon, prop.PropertyType.Name).ToString();
                            var fieldNames = TakeFieldNames(propQuery);
                            DataComboBox cbx = new DataComboBox();
                            #region Düzenleme için bilgi getirme kodu
                            Dictionary<string, string> valueList = new Dictionary<string, string>();
                            DBConnection.QueryConnection.Open();
                            using (MySqlCommand cmd = new MySqlCommand(propQuery, DBConnection.QueryConnection))
                            {
                                using (MySqlDataReader rd = cmd.ExecuteReader())
                                {
                                    string values = "";
                                    while (rd.Read())
                                    {
                                        if (rd.HasRows)
                                        {

                                            cbx.Items.Add(rd[1]);
                                            cbx.RealValues.Add(rd[0].ToString());
                                            //for (int i = 0; i < fieldNames.Length; i++)
                                            //{
                                            //    valueList.Add(fieldNames[i],rd[i].ToString());

                                            //}
                                        }
                                    }
                                }
                            }
                            DBConnection.QueryConnection.Close();
                            if (cbx.Items.Count!=0)
                            {
                                cbx.SelectedIndex = 0;
                            }
                            requiredControl = cbx;
                            #endregion
                            // Property adlarını ayırıp, Ayrı ayrı çalıştırmak gerekiyor
                            //DBConnection.DbCon
                            break;
                        default:

                            requiredControl = GetControl(attribute.DesiredControl, attribute.Source);

                            break;
                    }
                    if (requiredControl != null)
                    {
                        string propName = prop.Name;
                        //prop.SetValue(SelectedObject, "Test");
                        //var propValue = prop.GetValue(SelectedObject);
                        var lbl = new System.Windows.Forms.Label
                        {
                            Text = propName,
                            Location = new Point(0, y),
                            AutoSize = true
                        };
                        requiredControl.Size = new Size(150, 25);
                        requiredControl.Location = new Point(x, y);
                        //requiredControl.Text = propValue.ToString();
                        y += difference;
                        panelPropArea.Controls.Add(lbl);
                        panelPropArea.Controls.Add(requiredControl);
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
            }
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
