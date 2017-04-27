using System;
using System.Windows.Forms;

namespace CRMKurs.CustomTools
{
    class PhoneTextBox:TextBox
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (!char.IsDigit(Convert.ToChar(e.KeyValue)))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
