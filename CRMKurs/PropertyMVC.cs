using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    class PropertyMVC : Attribute
    {
        public ControlEnum DesiredControl { get; set; }
        public object[] Source { get; set; }

        public PropertyMVC(ControlEnum desiredControl)
        {
            DesiredControl = desiredControl;
        }
        public PropertyMVC(ControlEnum desiredControl,params object[] source)
        {
            DesiredControl = desiredControl;
            Source = source;
        }

    }

    public enum ControlEnum
    {
        TextBox,
        Combobox,
        MultipleAdder,
        Entity,
        NumericUpDown,
        DateTime
    }
}
