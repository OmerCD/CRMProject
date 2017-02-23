using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs.Öğrenci
{
    public partial class frmÖğrenciDüzenle : Form
    {
        int _öğrenciID;
        public frmÖğrenciDüzenle(int ÖğrenciId)
        {
            InitializeComponent();
            _öğrenciID = ÖğrenciId;
        }

        private void frmÖğrenciDüzenle_Load(object sender, EventArgs e)
        {

        }

        private void btnEpostaMA_Click(object sender, EventArgs e)
        {
            frmMultipleAdder frm = new frmMultipleAdder(txtBEposta.Text,typeof(EmailTextBox));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBEposta.Text = frm.Result;
            }
            frm.Dispose();
            frm = null;
        }

        private void btnTelefonMA_Click(object sender, EventArgs e)
        {
            frmMultipleAdder frm = new frmMultipleAdder(txtBTelefon.Text,typeof(TextBox));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBTelefon.Text = frm.Result;
            }
            frm.Dispose();
            frm = null;
        }
    }
}
