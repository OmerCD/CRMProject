using System.Collections.Generic;
using System.Windows.Forms;

namespace CRMKurs.CustomTools
{
    class DataComboBox : ComboBox
    {
        public DataComboBox() : base()
        {
            RealValues= new List<string>();
        }
        public string GetSelectedValue => (RealValues[SelectedIndex]);
        public List<string> RealValues { get; set; }
        public string this[int i] => RealValues[i];
    }
}
