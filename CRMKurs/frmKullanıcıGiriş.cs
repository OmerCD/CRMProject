using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using CRMKurs.EntityClasses;
using DesktopAppCRM;

namespace CRMKurs
{
    public partial class frmKullanıcıGiriş : Form //Bitmedi. Owner belirlenip onun IDsi ile her sütuna giriş yapılmalı.
    {
        public MainBoss _bossInformation;
        private DialogResult _tempRes;
        readonly string _filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CRM\\settings";
        private bool _okToLogin = false;
        public frmKullanıcıGiriş()
        {
            InitializeComponent();
            DBConnection.DbCon = new ModelBuild();
        }


        MainBoss ReadCipher()
        {
            using (var sr = new StreamReader(_filePath))
            {
                var encryptedText = sr.ReadToEnd();
                if (encryptedText=="" || string.IsNullOrEmpty(encryptedText))
                {
                    return null;
                }
                var uText = Cipher.Decrypt(encryptedText, "Mr. Poopybutthole");
                sr.Close();
                uText = uText.Replace("$", "");
                var parts = uText.Split('ô');
                var KullanıcıAdı = parts[0];
                var Id = parts[1];
                Id=Id.Substring(0, Id.IndexOf("\0"));
                var boss = DBConnection.DbCon.MainBoss.FirstOrDefault(x => x.KullaniciAdi == KullanıcıAdı && x.OwnerId == Id);
                //MessageBox.Show(uText);
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
                    using (File.Create(_filePath))
                    _okToLogin = true;
                    _tempRes=DialogResult.Yes;
                    return frm.BossInfo;
                }
                return null;
            }
        }
        private void frmKullanıcıGiriş_Load(object sender, EventArgs e)
        {
            //Worker wrk = new Worker { KullaniciAdi = "Enes", Sifre = "123456", OwnerId = "1", Statu = Worker.Status.Yönetici };
            //DBConnection.DbCon.Worker.Add(wrk);
            //DBConnection.DbCon.SaveChanges();

            _tempRes = DialogResult.Cancel;
            if (File.Exists(_filePath))
            {
                _bossInformation = ReadCipher();
                if (_bossInformation != null)
                {
                    _okToLogin = true;
                }
                else
                {
                    _bossInformation = BossLogin();
                }
            }
            else
            {
                _bossInformation = BossLogin();
            }
            if (!_okToLogin) //Web Sitesine yönlendirme
            {
                MessageBox.Show("Sunucu girişi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("www.deletecrm.com");
                Application.Exit();
            }
            else
            {
                if (_bossInformation != null)
                {
                    DataBaseConnectionOptions.OwnerUserId = _bossInformation.OwnerId;
                }
            }
            
        }

        private void frmKullanıcıGiriş_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Login())
                {
                    _tempRes = DialogResult.OK;
                    Close();
                }
            }
        }
        bool Login()
        {
            //DBConnection.DbCon.Worker.Add(new Worker
            //{
            //    OwnerId = "1",
            //    KullaniciAdi = "Enes",
            //    EMail = "test@test.com",
            //    Sifre = "123456",
            //    Statu = Worker.Status.Kullanıcı
            //});
            //DBConnection.DbCon.SaveChanges();
            if (Check)
            {
                var workers = DBConnection.DbCon.Worker;
                if (workers.Any())
                {
                    var worker = DBConnection.DbCon.Worker.FirstOrDefault(x => x.KullaniciAdi == txtKullanıcıAdı.Text && x.Sifre == txtŞifre.Text && x.OwnerId == DataBaseConnectionOptions.OwnerUserId);
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

        private void frmKullanıcıGiriş_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = _tempRes;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.deletecrm.com");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                _tempRes = DialogResult.OK;
                Close();
            }
        }
    }
}
