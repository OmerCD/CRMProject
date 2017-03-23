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

namespace CRMKurs
{
    public partial class frmBossLogin : Form
    {
        public MainBoss BossInfo;
        public frmBossLogin()
        {
            InitializeComponent();

        }

        private void frmBossLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {

                BossInfo = DBConnection.DbCon.MainBoss.FirstOrDefault(x => x.KullaniciAdi == txtKullanıcıAdı.Text && x.Sifre == txtŞifre.Text);
                if (BossInfo == null)
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre", "Hata", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                DialogResult=DialogResult.OK;
                Close();
            }
        }

        private void frmBossLogin_Load(object sender, EventArgs e)
        {
            //DBConnection.DbCon.MainBoss.Add(new MainBoss
            //{
            //    KullaniciAdi = "Ömer",
            //    Sifre = "12345",
            //    OwnerId = "1"
            //});
            //DBConnection.DbCon.SaveChanges();
        }
    }
}
