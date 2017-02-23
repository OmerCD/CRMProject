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
    public partial class frmÖğrenci : Form
    {
        public frmÖğrenci()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Öğrenci.frmÖğrenciDüzenle frm = new Öğrenci.frmÖğrenciDüzenle(-1); // Yeni öğrenci oluşturmak için -1 değeri, varolanı düzenlemek için öğrenci ID'si girilecek
            frm.ShowDialog();
        }
    }
}
