using System;
using System.Diagnostics;
using System.Linq;
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
                Login();
            }
        }

        private void Login()
        {
            BossInfo = DBConnection.DbCon.MainBoss.FirstOrDefault(x => x.KullaniciAdi == txtKullanıcıAdı.Text && x.Sifre == txtŞifre.Text);
            if (BossInfo == null)
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.deletecrm.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
