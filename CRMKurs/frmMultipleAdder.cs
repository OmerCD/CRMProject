using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CRMKurs
{
    public partial class frmMultipleAdder : Form
    {
        string _current,_result;
        public string Result=>_result;
        Type _creationType;
        int _x, _y,_counter;
        private const int Spacing = 30;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
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
            var attTag = _counter.ToString();
            var lbl = new Label(); //Numaralandırma için labellar
            lbl.ForeColor = Color.White;
            var btn = new Button(); //Alan çıkarmak için butonlar
            btn.Size = new Size(20, 20);
            btn.Text = "-";
            btn.Tag = attTag;
            btn.Click += Btn_Click;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
            var cont = (Control)Activator.CreateInstance(_creationType); //Verilen control tipindeki instancelar

            
            cont.Location = new Point(_x, _y);
            cont.Tag = attTag;
            lbl.Location = new Point(_x - 15, _y);
            btn.Location = new Point(_x + 110, _y);
            lbl.Text = _counter.ToString();
            lbl.Tag = attTag;
            _y += Spacing;
            _counter++;
            container.Controls.Add(btn);
            container.Controls.Add(cont);
            container.Controls.Add(lbl);
            return cont;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            _counter--;
            _y -= Spacing;
            var tagToRemove = ((Control) sender).Tag;
            var tagCheck = Convert.ToInt32(tagToRemove);
            var controlsToRemove = new List<Control>();
            foreach (Control cont in GeneralPanel.Controls)
            {
                if (cont.Tag==tagToRemove)
                {
                    controlsToRemove.Add(cont);
                    
                }
                else if (Convert.ToInt32(cont.Tag) > tagCheck)
                {
                    cont.Location = new Point(cont.Location.X, cont.Location.Y - Spacing);
                    var newTag = (Convert.ToInt32(cont.Tag) - 1).ToString();
                    cont.Tag = newTag;
                    if (cont is Label)
                    {
                        cont.Text = newTag;
                    }
                }
            }
            foreach (var item in controlsToRemove)
            {
                GeneralPanel.Controls.Remove(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMultipleAdder_Load(object sender, EventArgs e)
        {
            var seperated = _current.Split(';');
            foreach (var seperate in seperated)
            {
                if (seperate == string.Empty)
                {
                    continue;
                }
                AddControl(GeneralPanel).Text=seperate;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_counter>=11)
            {
                MessageBox.Show("10'dan fazla alan ekleyemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddControl(GeneralPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _result = "";
            foreach (Control cont in GeneralPanel.Controls)
            {
                if (cont.GetType() != _creationType) continue;
                if (cont is CustomTools.EmailTextBox)
                {
                    if (cont.Text.Length > 0)
                    {
                        if (!(cont as CustomTools.EmailTextBox).CorrectCheck())
                        {
                            MessageBox.Show("E-Posta adreslerinin doğruluğunu kontrol edin\n" + cont.Text, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                if (cont.Text == string.Empty)
                {
                    continue;
                }
                _result += cont.Text + ';';
            }
            DialogResult = DialogResult.OK;
        }
    }
}
