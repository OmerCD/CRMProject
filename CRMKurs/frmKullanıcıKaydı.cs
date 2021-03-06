﻿using System;
using System.Windows.Forms;
using static CRMKurs.EntityClasses.Staff.Worker;

namespace CRMKurs
{
    public partial class frmKullanıcıKaydı : Form
    {
        public frmKullanıcıKaydı()
        {
            InitializeComponent();
        }
     
        private void frmKullanıcıKaydı_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(Status)))
            {
                cBStatü.Items.Add(item);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calisan = new EntityClasses.Staff.Worker {
                KullaniciAdi =txtKullanıcı.Text,
                Sifre=txtŞifre.Text
            };
            DBConnection.DbCon.Worker.Add(calisan);
            DBConnection.DbCon.SaveChanges();
        }
    }
}
