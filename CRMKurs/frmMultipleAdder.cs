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
        void ReArrangeControls(List<Control> controls)
        {

        }
        Control AddControl(Control container) // Her butona ve her control'e ID vermek gerekiyor
        {
            string attTag = _counter.ToString();
            Label lbl = new Label(); //Numaralandırma için labellar
            Button btn = new Button(); //Alan çıkarmak için butonlar
            btn.Size = new Size(25, 25);
            btn.Text = "-";
            btn.Tag = attTag;
            btn.Click += Btn_Click;
            Control cont = (Control)Activator.CreateInstance(_creationType); //Verilen control tipindeki instancelar

            
            cont.Location = new Point(_x, _y);
            cont.Tag = attTag;
            lbl.Location = new Point(_x - 15, _y);
            btn.Location = new Point(_x + 100, _y);
            lbl.Text = _counter.ToString();
            lbl.Tag = attTag;
            _y += SPACING;
            _counter++;
            container.Controls.Add(btn);
            container.Controls.Add(cont);
            container.Controls.Add(lbl);
            return cont;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            var tagToRemove = (sender as Control).Tag;
            int tagCheck = Convert.ToInt32(tagToRemove);
            List<Control> controlsToRemove = new List<Control>();
            foreach (Control cont in GeneralPanel.Controls)
            {
                if (cont.Tag==tagToRemove)
                {
                    controlsToRemove.Add(cont);
                    
                }
                else if (Convert.ToInt32(cont.Tag) > tagCheck)
                {
                    cont.Location = new Point(cont.Location.X, cont.Location.Y - SPACING);
                    if (cont is Label)
                    {
                        cont.Text = (Convert.ToInt32(cont.Text) - 1).ToString();
                    }
                }
            }
            foreach (var item in controlsToRemove)
            {
                GeneralPanel.Controls.Remove(item);
            }
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
                if (cont.GetType() == _creationType)
                {
                    if (cont.Text == string.Empty)
                    {
                        continue;
                    }
                    _result += cont.Text + ';';
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
