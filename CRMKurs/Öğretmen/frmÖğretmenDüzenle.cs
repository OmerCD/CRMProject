using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs.Öğretmen
{
    public partial class frmÖğretmenDüzenle : Form
    {
        public frmÖğretmenDüzenle()
        {
            InitializeComponent();
        }

        private void frmÖğretmenDüzenle_Load(object sender, EventArgs e)
        { 

           
            foreach (var item in Settings.Hitaplar)
            { 
                cBHitap.Items.Add(item);
            }
            

            
        }

        private void btnEpostaMA_Click(object sender, EventArgs e)
        {
            frmMultipleAdder frm = new frmMultipleAdder(txtBEposta.Text, typeof(CustomTools.EmailTextBox));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBEposta.Text = frm.Result;
            }
            frm.Dispose();
            frm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityClasses.Öğretmen öğretmen = new EntityClasses.Öğretmen {
                Adres = txtBAdres.Text,
                AdSoyad = txtBAdSoyad.Text,
                Hitap = cBHitap.Text,
                EPosta = txtBEposta.Text,
                Okul = DBConnection.dbCon.Okul.First(x => x.Id == cBOkul.GetSelectedValue),
                Sınıf = cBSınıf.Text,
                Telefon = txtBTelefon.Text,
                İl = cBİl.Text,
                Bölge = txtBBölge.Text,
                Ülke = txtBÜlke.Text,
                PostaKodu = txtBPostaKodu.Text,



            };
            DBConnection.dbCon.Öğretmen.Add(öğretmen);
            DBConnection.dbCon.SaveChanges();

        }

        private void btnTelefonMA_Click(object sender, EventArgs e)
        {
            frmMultipleAdder frm = new frmMultipleAdder(txtBTelefon.Text, typeof(CustomTools.PhoneTextBox));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBTelefon.Text = frm.Result;
            }
            frm.Dispose();
            frm = null;
        }
    }
}
