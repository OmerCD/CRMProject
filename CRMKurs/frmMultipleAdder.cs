using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs
{
    public partial class frmMultipleAdder : Form
    {
        string _current,_result;
        public string Result=>_result;
        Type _creationType;
        int _x, _y,_counter;
        readonly int SPACING = 30;
        public frmMultipleAdder(string Current,Type type)
        {
            InitializeComponent();
            _x = 30;
            _y = 5;
            _counter = 1;
            _current = Current;
            _creationType = type;
        }
        Control AddControl(Control container) // Her butona ve her control'e ID vermek gerekiyor
        {
            Label lbl = new Label();
            Button btn = new Button();
            btn.Size = new Size(25, 25);
            btn.Text = "-";
            Control cont = (Control)Activator.CreateInstance(_creationType);
            cont.Location = new Point(_x, _y);
            lbl.Location = new Point(_x - 15, _y);
            btn.Location = new Point(_x + 100, _y);
            lbl.Text = _counter.ToString();
            _y += SPACING;
            _counter++;
            container.Controls.Add(btn);
            container.Controls.Add(cont);
            container.Controls.Add(lbl);
            return cont;
        }
        private void frmMultipleAdder_Load(object sender, EventArgs e)
        {
            
            string[] seperated = _current.Split(';');
            for (int i = 0; i < seperated.Length; i++)
            {
                if (seperated[i] == string.Empty)
                {
                    continue;
                }
                AddControl(GeneralPanel).Text=seperated[i];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddControl(GeneralPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _result = "";
            foreach (Control cont in GeneralPanel.Controls)
            {
                if (cont.Text==string.Empty)
                {
                    continue;
                }
                _result += cont.Text + ';';
            }
            DialogResult = DialogResult.OK;
        }
    }
}
