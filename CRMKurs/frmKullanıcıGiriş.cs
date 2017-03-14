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
            using (StreamReader sr = new StreamReader(_filePath))
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
                var boss = DBConnection.DbCon.Bosses.FirstOrDefault(x => x.KullanıcıAdı == KullanıcıAdı && x.OwnerId == Id);
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
                    using (File.Create(_filePath))
                    _okToLogin = true;
                    return frm.BossInfo;
                }
                return null;
            }
        }
        private void frmKullanıcıGiriş_Load(object sender, EventArgs e)
        {
            
            _tempRes = DialogResult.Cancel;
            if (File.Exists(_filePath))
            {
                _bossInformation = ReadCipher();
                if (_bossInformation != null)
                {
                    _okToLogin = true;
                    _tempRes = DialogResult.OK;
                }
                else
                {
                    _bossInformation = BossLogin();
                    _tempRes = DialogResult.Yes;
                }
            }
            else
            {
                _bossInformation = BossLogin();
                _tempRes = DialogResult.Yes;
            }
            if (!_okToLogin) //Web Sitesine yönlendirme
            {
                MessageBox.Show("Sunucu girişi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                if (_bossInformation != null)
                    DataBaseConnectionOptions.OwnerUserId = _bossInformation.OwnerId;
            }
        }

        private void frmKullanıcıGiriş_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Login())
                {
                    DialogResult = _tempRes;

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

        private void frmKullanıcıGiriş_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = _tempRes;
        }
    }
}
