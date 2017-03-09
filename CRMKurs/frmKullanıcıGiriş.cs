using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CRMKurs.EntityClasses;
using DesktopAppCRM;

namespace CRMKurs
{
    public partial class frmKullanıcıGiriş : Form //Bitmedi. Owner belirlenip onun IDsi ile her sütuna giriş yapılmalı.
    {
        readonly string _filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CRM\\settings";
        private bool _okToLogin = false;
        public frmKullanıcıGiriş()
        {
            InitializeComponent();
        }

        void WriteCipher(MainBoss boss)
        {
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.Write(Cipher.Encrypt("$" + boss.KullanıcıAdı + "ô" + boss.OwnerId + "$", "Mr. Poopybutthole"));
            }
        }

        MainBoss ReadCipher()
        {
            using (StreamReader sr = new StreamReader(_filePath))
            {
                var uText = Cipher.Decrypt(sr.ReadToEnd(), "Mr. Poopybutthole");
                uText = uText.Replace("$", "");
                var parts = uText.Split('ô');
                var boss = DBConnection.DbCon.Bosses.FirstOrDefault(x => x.KullanıcıAdı == parts[0] && x.Şifre == parts[1]);
                MessageBox.Show(uText);
                return boss;
            }
        }

        MainBoss BossLogin()
        {
            using (var frm = new frmBossLogin())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CRM\\");
                    File.Create(_filePath);
                    _okToLogin = true;
                    return frm.BossInfo;
                }
                return null;
            }
        }
        private void frmKullanıcıGiriş_Load(object sender, EventArgs e)
        {
            MainBoss tempBoss;
            if (File.Exists(_filePath))
            {
                tempBoss = ReadCipher();
                if (tempBoss != null)
                {
                    _okToLogin = true;
                }
                else
                {
                    tempBoss = BossLogin();
                }
            }
            else
            {
                tempBoss = BossLogin();
            }
            if (!_okToLogin) //Web Sitesine yönlendirme
            {
                MessageBox.Show("Sunucu girişi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                if (tempBoss != null)
                    DataBaseConnectionOptions.OwnerUserId = tempBoss.OwnerId;
            }
        }

        private void frmKullanıcıGiriş_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Login())
                {
                    frmKullanıcıGiriş g = new frmKullanıcıGiriş();
                    MainCRMWindow f = new MainCRMWindow();

                    f.Show();
                    g.Close();

                }
            }
        }
        bool Login()
        {
            if (Check)
            {
                var workers = DBConnection.DbCon.Workers;
                if (workers.Any())
                {
                    var worker = DBConnection.DbCon.Workers.First(x => x.KullanıcıAdı == txtKullanıcıAdı.Text && x.Şifre == txtŞifre.Text);
                    if (worker == null)
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    return true;
                }
                return false;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı 4 karakterden\nŞifre 6 karakterden kısa olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        bool Check => txtKullanıcıAdı.TextLength >= 4 && txtŞifre.TextLength >= 6;
    }
}
