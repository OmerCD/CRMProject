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
    public partial class frmOkul : Form
    {
        public frmOkul()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmOkulDüzenle frm = new frmOkulDüzenle("-1");
            frm.ShowDialog();
        }

        private void frmOkul_Load(object sender, EventArgs e)
        {
            RefreshSchools();
        }
        void RefreshSchools()
        {
            List<EntityClasses.Okul> okulList = DBConnection.dbCon.Okul.ToList();
            foreach (var okul in okulList)
            {
                ListViewItem lvItem = new ListViewItem(new string[] { okul.AdSoyad, okul.Telefon });
                lVOkullar.Items.Add(lvItem);
            }
        }

        private void lVOkullar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVOkullar.SelectedIndices.Count == 0) return;
            string selectedPhone = lVOkullar.Items[lVOkullar.SelectedIndices[0]].SubItems[1].Text;
            EntityClasses.Okul okul = DBConnection.dbCon.Okul.ToList().First(x => x.Telefon == selectedPhone);
            lblAdSoyad.Text = okul.AdSoyad;
            lblBölge.Text = okul.Bölge;
            lblEposta.Text = okul.EPosta;
            lblPostaKodu.Text = okul.PostaKodu;
            lblTür.Text = okul.Tür;
            lblÜlke.Text = okul.Ülke;
            lblİl.Text = okul.İl;
            lblTelefon.Text = okul.Telefon;
            txtBAdres.Text = okul.Adres;
            txtBNotlar.Text = okul.Notlar;
        }
    }
}
