using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        void Test()
        {
            Type objType = SelectedObject.GetType();
            var props = objType.GetProperties();
            foreach (var prop in props)
            {
                var attr = prop.GetCustomAttributes(typeof(PropertyMVC), false);
                if (attr.Length != 0)
                {
                    foreach (PropertyMVC attribute in attr)
                    {
                        //var attribute = (PropertyMVC) attr[0];
                        switch (attribute.DesiredControl)
                        {
                            case ControlEnum.MultipleAdder:

                                break;
                            case ControlEnum.Entity:
                                var testValue = GetPropValue(DBConnection.DbCon, objType.Name);
                                    //  Class adını alıp property adlarını aratma. Fakat Property'i class ya da yeniden property olarak çalıştırmak gerekiyor.
                                string propString = (testValue.ToString());
                                    // Property adlarını ayırıp, Ayrı ayrı çalıştırmak gerekiyor
                                Console.WriteLine("Test");
                                //DBConnection.DbCon
                                break;
                            default:
                                Controls.Add(GetControl(attribute.DesiredControl));
                                break;
                        }
                    }
                }
            }
        }
        public object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
        Control GetControl(ControlEnum cEnum)
        {
            if (cEnum == ControlEnum.TextBox)
            {
                return new TextBox();
            }
            if (cEnum == ControlEnum.Combobox)
            {
                return new ComboBox();
            }
            if (cEnum == ControlEnum.NumericUpDown)
            {
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
