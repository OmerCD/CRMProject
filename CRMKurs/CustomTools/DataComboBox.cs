using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs.CustomTools
{
    class DataComboBox : ComboBox
    {
        public string GetSelectedValue => (RealValues[SelectedIndex]);
        public List<string> RealValues { get; set; }
        public string this[int i] => RealValues[i];
    }
}
