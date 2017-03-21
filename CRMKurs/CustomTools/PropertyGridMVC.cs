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
        public object SelectedObject { get; set; }
        public PropertyGridMVC(object Object)
        {
            InitializeComponent();
            SelectedObject = Object;
            Test();
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
            Type objType = SelectedObject.GetType();
            var props = objType.GetProperties();
            int x=30, y=5;
            int difference=30;
            var tableQuery = GetPropValue(DBConnection.DbCon, objType.Name).ToString(); //  verilen tabloyu almak için query'i veriyor

            foreach (var prop in props)
            {
                var attr = prop.GetCustomAttributes(typeof(PropertyMVC), false);
                if (attr.Length != 0)
                {
                    var attribute = (PropertyMVC)attr[0];
                    switch (attribute.DesiredControl)
                    {
                        case ControlEnum.MultipleAdder:

                            break;
                        case ControlEnum.Entity:
                            //var propQuery = GetPropValue(DBConnection.DbCon, prop.Name).ToString();
                            //var fieldNames = TakeFieldNames(propQuery);

                            #region Düzenleme için bilgi getirme kodu
                            //Dictionary<string, string> valueList = new Dictionary<string, string>();
                            //DBConnection.QueryConnection.Open();
                            //using (MySqlCommand cmd = new MySqlCommand(propQuery, DBConnection.QueryConnection))
                            //{
                            //    using (MySqlDataReader rd = cmd.ExecuteReader())
                            //    {
                            //        string values = "";
                            //        while (rd.Read())
                            //        {
                            //            for (int i = 0; i < rd.FieldCount; i++)
                            //            {
                            //                valueList[fieldNames[i]]= rd[i].ToString();
                            //            }

                            //        }
                            //    }
                            //}
                            //DBConnection.QueryConnection.Close();

                            #endregion
                            // Property adlarını ayırıp, Ayrı ayrı çalıştırmak gerekiyor
                            //DBConnection.DbCon
                            break;
                        default:
                            string propName = prop.Name;
                            prop.SetValue(SelectedObject,"Test");
                            var propValue = prop.GetValue(SelectedObject);
                            var lbl = new System.Windows.Forms.Label
                            {
                                Text = propName,
                                Location = new Point(0, y),
                                AutoSize = true
                            };
                            var tempControl = GetControl(attribute.DesiredControl,attribute.Source);
                            tempControl.Size= new Size(150,25);
                            tempControl.Location= new Point(x,y);
                            tempControl.Text = propValue.ToString();
                            y += difference;
                            Controls.Add(lbl);
                            Controls.Add(tempControl);
                            break;
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
                    if (sourceObjects.Length>0)
                    {
                        tempC.Items.AddRange(sourceObjects);
                    }
                    return tempC;
                case ControlEnum.NumericUpDown:
                    return new NumericUpDown();
            }
            return null;
        }
        public PropertyGridMVC()
        {
            InitializeComponent();
        }
    }
}
