using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs
{
    class EmailTextBox : TextBox
    {
        public EmailTextBox() : base()
        {
            MaxLength = 30;
        }
        public bool CorrectCheck()
        {
            if (Text.Length < 8) return false;
            if (!Text.Contains("@")) return false;
            if (Text.Substring(0, 3).Contains("@")) return false;
            if (Text.Split('@')[2].Length < 4) return false;
            return true;
        }
    }
}
