using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs
{
    public partial class frmKullanıcıGiriş : Form
    {
        public frmKullanıcıGiriş()
        {
            InitializeComponent();
        }

        private void frmKullanıcıGiriş_Load(object sender, EventArgs e)
        {

        }

        private void frmKullanıcıGiriş_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Login())
                {
                    //Ana Sayfa Açılacak
                }
            }
        }
        bool Login()
        {
            if (Check)
            {
                var workers = DBConnection.dbCon.Workers;
                if (workers.Count() > 0)
                {
                    EntityClasses.Staff.Worker worker = DBConnection.dbCon.Workers.First(x => x.KullanıcıAdı == txtKullanıcıAdı.Text && x.Şifre == txtŞifre.Text);
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
        bool Check
        {
            get
            {
                if (txtKullanıcıAdı.TextLength < 4)
                {
                    return false;
                }
                if (txtŞifre.TextLength < 6)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
