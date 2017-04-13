using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMKurs.EntityClasses;
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
            //var testPerson = new Person
            //{
            //    OwnerId = "1",
            //    Institution = DBConnection.DbCon.Institution.First(),
            //    PersonTypes = DBConnection.DbCon.PersonTypes.First(),
            //    Adres = "testAdres",
            //    Bolge = "testBolge",
            //    EPosta = "testEposta",
            //    Hitap = "Garışık",
            //    Il = "testIl",
            //    Isim = "Namık",
            //    Notlar = "Not yok çay için",
            //    PostaKodu = "Komadı",
            //    Sinif = "3/c",
            //    Telefon = "0543",
            //    Tur = "İnsanımsı",
            //    Ulke = "Burası"
            //};
            var newEntity = (Person)propGrid.SelectedObject;
            DBConnection.DbCon.Person.Add(newEntity);
            //var newPersonType = (PersonTypes) propGrid.SelectedObject;
            //DBConnection.DbCon.PersonTypes.Add(newPersonType);
            DBConnection.DbCon.SaveChanges();
            //using (var frm = new frmKişDüzenle("-1"))
            //{
            //    if(frm.ShowDialog()==DialogResult.OK) RefreshPeople();
            //}
            //var frm = new frmKişDüzenle("-1"); 
            //frm.ShowDialog();
        }

        private void frmÖğrenci_Load(object sender, EventArgs e)
        {
            RefreshPeople();
            //propGrid.SelectedObject = new PersonTypes
            //{
            //    Isim = "Test1",
            //};
            propGrid.SelectedObject = new Person
            {
                Adres = "Yok",
                Bolge = "Yok",
                EPosta = "asdasd@asdasd.com",
                Il = "İstanbul",
                Isim = "Test",
                Notlar = "Yok",
                PostaKodu = "34303",
                Telefon = "05468963589",
                Ulke = "Türkiye",
                Tur = "Yok",
                Sinif = "Yok"
            };
        }

        private void RefreshPeople()
        {
            var öğrenciList = DBConnection.DbCon.Person.ToList().Where(x => x.OwnerId == DataBaseConnectionOptions.OwnerUserId);
            foreach (var öğrenci in öğrenciList)
            {
                var lvItem = new ListViewItem(new [] { öğrenci.Isim, öğrenci.Telefon });
                lVKişiler.Items.Add(lvItem);
            }
        }

        private void lVÖğrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVKişiler.SelectedIndices.Count == 0) return;
            string selectedPhone = lVKişiler.Items[lVKişiler.SelectedIndices[0]].SubItems[1].Text;
            var öğrenci=DBConnection.DbCon.Person.First(x => x.Telefon == selectedPhone && x.OwnerId == DataBaseConnectionOptions.OwnerUserId);
            propGrid.SelectedObject = öğrenci;
            lblAdSoyad.Text = öğrenci.Isim;
            lblBölge.Text = öğrenci.Bolge;
            lblEposta.Text = öğrenci.EPosta;
            lblHitap.Text = öğrenci.Hitap;
            lblOkul.Text = öğrenci.Institution.Isim;
            lblPostaKodu.Text = öğrenci.PostaKodu;
            lblTelefon.Text = öğrenci.Telefon;
            lblSınıf.Text = öğrenci.Sinif;
            lblTür.Text = öğrenci.Tur;
            lblÜlke.Text = öğrenci.Ulke;
            lblİl.Text = öğrenci.Il;
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
