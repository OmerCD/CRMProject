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

namespace CRMKurs.Kişi
{
    public partial class frmKişi : Form
    {
        public frmKişi()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            using (var frm = new frmKişDüzenle("-1"))
            {
                if(frm.ShowDialog()==DialogResult.OK) RefreshPeople();
            }
            //var frm = new frmKişDüzenle("-1"); 
            //frm.ShowDialog();
        }

        private void frmÖğrenci_Load(object sender, EventArgs e)
        {
            RefreshPeople();
        }

        private void RefreshPeople()
        {
            var öğrenciList = DBConnection.DbCon.People.ToList().Where(x => x.OwnerId == DataBaseConnectionOptions.OwnerUserId);
            foreach (var öğrenci in öğrenciList)
            {
                var lvItem = new ListViewItem(new [] { öğrenci.İsim, öğrenci.Telefon });
                lVKişiler.Items.Add(lvItem);
            }
        }

        private void lVÖğrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVKişiler.SelectedIndices.Count == 0) return;
            string selectedPhone = lVKişiler.Items[lVKişiler.SelectedIndices[0]].SubItems[1].Text;
            var öğrenci=DBConnection.DbCon.People.First(x => x.Telefon == selectedPhone && x.OwnerId == DataBaseConnectionOptions.OwnerUserId);

            lblAdSoyad.Text = öğrenci.İsim;
            lblBölge.Text = öğrenci.Bölge;
            lblEposta.Text = öğrenci.EPosta;
            lblHitap.Text = öğrenci.Hitap;
            lblOkul.Text = öğrenci.Okul.İsim;
            lblPostaKodu.Text = öğrenci.PostaKodu;
            lblTelefon.Text = öğrenci.Telefon;
            lblSınıf.Text = öğrenci.Sınıf;
            lblTür.Text = öğrenci.Tür;
            lblÜlke.Text = öğrenci.Ülke;
            lblİl.Text = öğrenci.İl;
            txtBAdres.Text = öğrenci.Adres;
            txtBNotlar.Text = öğrenci.Notlar;

        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (lVKişiler.SelectedIndices.Count == 0) return;
            var phoneNumber = lVKişiler.SelectedItems[0].SubItems["PhoneNumber"].Text;
            using (var frm = new frmKişDüzenle(phoneNumber))
            {
                if (frm.ShowDialog() == DialogResult.OK) RefreshPeople();
            }
        }
    }
}
