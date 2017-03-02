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
        string _öğrenciTelefon;
        public frmÖğrenciDüzenle(string ÖğrencTelefon)
        {
            InitializeComponent();
            _öğrenciTelefon = ÖğrencTelefon;
        }

        private void frmÖğrenciDüzenle_Load(object sender, EventArgs e)
        {
            cBİl.SelectedIndex= cBHitap.SelectedIndex = 0;
            var okullar =DBConnection.dbCon.Okul.ToArray();
            foreach (var okul in okullar)
            {
                cBOkul.Items.Add(okul.AdSoyad);
                cBOkul.RealValues.Add(okul.Id);
            }
            cBOkul.SelectedIndex = 0;
        }

        private void btnEpostaMA_Click(object sender, EventArgs e)
        {
            frmMultipleAdder frm = new frmMultipleAdder(txtBEposta.Text,typeof(CustomTools.EmailTextBox));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBEposta.Text = frm.Result;
            }
            frm.Dispose();
            frm = null;
        }

        private void btnTelefonMA_Click(object sender, EventArgs e)
        {
            frmMultipleAdder frm = new frmMultipleAdder(txtBTelefon.Text,typeof(CustomTools.PhoneTextBox));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBTelefon.Text = frm.Result;
            }
            frm.Dispose();
            frm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EntityClasses.Öğrenci öğrenci = new EntityClasses.Öğrenci {
            //    Adres=txtBAdres.Text,
            //    AdSoyad=txtBAdSoyad.Text,
            //    Bölge=txtBBölge.Text,
            //    EPosta=txtBEposta.Text,
            //    Hitap=cBHitap.SelectedItem.ToString(),
            //    Notlar=txtBNotlar.Text,
            //    Okul=cBOkul.SelectedItem.ToString(),
            //    PostaKodu=txtBPostaKodu.Text,
            //    Sınıf=cBSınıf.SelectedItem.ToString(),
            //    Telefon=txtBTelefon.Text,
            //    Tür=txtBTür.Text,
            //    Ülke=txtBÜlke.Text,
            //    İl=cBİl.SelectedItem.ToString()
            //};
            EntityClasses.Öğrenci öğrenci = new EntityClasses.Öğrenci
            {
                Adres = txtBAdres.Text,
                AdSoyad = txtBAdSoyad.Text,
                Bölge = txtBBölge.Text,
                EPosta = txtBEposta.Text,
                Hitap = cBHitap.SelectedItem.ToString(),
                Notlar = txtBNotlar.Text,
                Okul = DBConnection.dbCon.Okul.First(x => x.Id == cBOkul.GetSelectedValue),
                PostaKodu = txtBPostaKodu.Text,
                Sınıf = "TestSınıf",
                Telefon = txtBTelefon.Text,
                Tür = txtBTür.Text,
                Ülke = txtBÜlke.Text,
                İl = cBİl.SelectedItem.ToString()
            };
            DBConnection.dbCon.Öğrenci.Add(öğrenci);
            DBConnection.dbCon.SaveChanges();
        }
    }
}
