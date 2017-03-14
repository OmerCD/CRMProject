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

                BossInfo = DBConnection.DbCon.Bosses.FirstOrDefault(x => x.KullanıcıAdı == txtKullanıcıAdı.Text && x.Şifre == txtŞifre.Text);
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
            //DBConnection.DbCon.Bosses.Add(new MainBoss
            //{
            //    KullanıcıAdı = "Ömer",
            //    Şifre = "12345"
            //});
        }
    }
}
