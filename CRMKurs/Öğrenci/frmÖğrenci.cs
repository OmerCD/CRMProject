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
            Öğrenci.frmÖğrenciDüzenle frm = new Öğrenci.frmÖğrenciDüzenle("-1"); 
            frm.ShowDialog();
        }

        private void frmÖğrenci_Load(object sender, EventArgs e)
        {
            RefreshStudents();
        }
        void RefreshStudents()
        {
            List<EntityClasses.Öğrenci> öğrenciList = DBConnection.dbCon.Öğrenci.ToList();
            foreach (var öğrenci in öğrenciList)
            {
                ListViewItem lvItem = new ListViewItem(new string[] { öğrenci.AdSoyad, öğrenci.Telefon });
                lVÖğrenciler.Items.Add(lvItem);
            }
        }

        private void lVÖğrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVÖğrenciler.SelectedIndices.Count == 0) return;
            string selectedPhone = lVÖğrenciler.Items[lVÖğrenciler.SelectedIndices[0]].SubItems[1].Text;
            EntityClasses.Öğrenci öğrenci=DBConnection.dbCon.Öğrenci.First(x => x.Telefon == selectedPhone);

            lblAdSoyad.Text = öğrenci.AdSoyad;
            lblBölge.Text = öğrenci.Bölge;
            lblEposta.Text = öğrenci.EPosta;
            lblHitap.Text = öğrenci.Hitap;
            lblOkul.Text = öğrenci.Okul.AdSoyad;
            lblPostaKodu.Text = öğrenci.PostaKodu;
            lblTelefon.Text = öğrenci.Telefon;
            lblSınıf.Text = öğrenci.Sınıf;
            lblTür.Text = öğrenci.Tür;
            lblÜlke.Text = öğrenci.Ülke;
            lblİl.Text = öğrenci.İl;
            txtBAdres.Text = öğrenci.Adres;
            txtBNotlar.Text = öğrenci.Notlar;
        }
    }
}
