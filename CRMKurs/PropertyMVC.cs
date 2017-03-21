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

        public PropertyMVC(ControlEnum desiredControl)
        {
            DesiredControl = desiredControl;
        }

    }

    public enum ControlEnum
    {
        TextBox,
        Combobox,
        MultipleAdder,
        Entity,
        NumericUpDown
    }
}
