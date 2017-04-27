using System;
using System.Windows.Forms;

namespace CRMKurs
{
    public partial class frmPropsWithList : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        public frmPropsWithList(object selectedObject,string title)
        {
            InitializeComponent();
            propertyGridMVCList1.SelectedTable = selectedObject;
            labelTitle.Text = title;
            lblTitle.Text = title;
        }

        private void frmPropsWithList_Load(object sender, EventArgs e)
        {
            //propertyGridMVCList1.SelectedTable = new PersonTypes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
