﻿using System;
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
    public partial class frmKişDüzenle : Form
    {
        string _kişiTelefon;
        public frmKişDüzenle(string ÖğrencTelefon)
        {
            InitializeComponent();
            _kişiTelefon = ÖğrencTelefon;
        }

        void LoadFromPhone(string pNumb)
        {
            var person = DBConnection.DbCon.Person.First(x => x.Telefon == pNumb  && x.OwnerId == DataBaseConnectionOptions.OwnerUserId);
            if (person!=null)
            {
                txtSınıf.Text = person.Sınıf;
                txtBAdSoyad.Text = person.İsim;
                txtBAdres.Text = person.Adres;
                txtBBölge.Text = person.Bölge;
                txtBEposta.Text = person.EPosta;
                txtBNotlar.Text = person.Notlar;
                txtBPostaKodu.Text = person.PostaKodu;
                txtBTelefon.Text = pNumb;
                txtBTür.Text = person.Tür;
                txtBÜlke.Text = person.Ülke;
            }
        }
        private void frmÖğrenciDüzenle_Load(object sender, EventArgs e)
        {
            cBİl.SelectedIndex= cBHitap.SelectedIndex = 0;
            var okullar = DBConnection.DbCon.Institution.Where(x => x.OwnerId == DataBaseConnectionOptions.OwnerUserId).ToArray();
            foreach (var okul in okullar)
            {
                cBOkul.Items.Add(okul.İsim);
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
            using (var frm = new frmMultipleAdder(txtBTelefon.Text, typeof(CustomTools.PhoneTextBox)))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtBTelefon.Text = frm.Result;
                }
            }
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
            var kişi = new EntityClasses.Person
            {
                Adres = txtBAdres.Text,
                İsim = txtBAdSoyad.Text,
                Bölge = txtBBölge.Text,
                EPosta = txtBEposta.Text,
                Hitap = cBHitap.SelectedItem.ToString(),
                Notlar = txtBNotlar.Text,
                Okul = DBConnection.DbCon.Institution.First(x => x.Id == cBOkul.GetSelectedValue && x.OwnerId == DataBaseConnectionOptions.OwnerUserId),
                PostaKodu = txtBPostaKodu.Text,
                Sınıf = txtSınıf.Text,
                Telefon = txtBTelefon.Text,
                Tür = txtBTür.Text,
                Ülke = txtBÜlke.Text,
                İl = cBİl.SelectedItem.ToString(),
                OwnerId = DataBaseConnectionOptions.OwnerUserId
                
            };
            DBConnection.DbCon.Person.Add(kişi);
            DBConnection.DbCon.SaveChanges();
        }
    }
}
