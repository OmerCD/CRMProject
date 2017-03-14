using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppCRM;

namespace CRMKurs.Okul
{
    public partial class frmKurumDüzenle : Form
    {
        string _okulTelefon;
        public frmKurumDüzenle(string okulTelefon)
        {
            InitializeComponent();
            _okulTelefon = okulTelefon;
        }

        private void frmKurumDüzenle_Load(object sender, EventArgs e)
        {
            rbKurum.Select();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            EntityClasses.Institution okul = new EntityClasses.Institution
            {
                Adres = txtBAdres.Text,
                İsim = txtBAdSoyad.Text,
                Bölge = txtBBölge.Text,
                EPosta = txtBEposta.Text,
                Notlar = txtBNotlar.Text,
                PostaKodu = txtBPostaKodu.Text,
                Telefon = txtBTelefon.Text,
                Tür = txtBTür.Text,
                Ülke = txtBÜlke.Text,
                İl = cBİl.SelectedItem.ToString(),
                OwnerId = DataBaseConnectionOptions.OwnerUserId
                
            };
            DBConnection.DbCon.Institutions.Add(okul);
            DBConnection.DbCon.SaveChanges();
        }
    }
}
