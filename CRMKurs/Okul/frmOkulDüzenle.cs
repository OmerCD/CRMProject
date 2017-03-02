using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs.Okul
{
    public partial class frmOkulDüzenle : Form
    {
        string _okulTelefon;
        public frmOkulDüzenle(string okulTelefon)
        {
            InitializeComponent();
            _okulTelefon = okulTelefon;
        }

        private void frmOkulDüzenle_Load(object sender, EventArgs e)
        {
            rbKurum.Select();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            EntityClasses.Okul okul = new EntityClasses.Okul
            {
                Adres = txtBAdres.Text,
                AdSoyad = txtBAdSoyad.Text,
                Bölge = txtBBölge.Text,
                EPosta = txtBEposta.Text,
                Notlar = txtBNotlar.Text,
                PostaKodu = txtBPostaKodu.Text,
                Telefon = txtBTelefon.Text,
                Tür = txtBTür.Text,
                Ülke = txtBÜlke.Text,
                İl = cBİl.SelectedItem.ToString()
            };
            DBConnection.dbCon.Okul.Add(okul);
            DBConnection.dbCon.SaveChanges();
        }
    }
}
