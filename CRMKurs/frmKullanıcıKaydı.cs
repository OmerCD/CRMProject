using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppCRM;
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
            if (txtŞifre.Text != txtŞifret.Text) return;
            var calisan = new EntityClasses.Staff.Worker {
                KullanıcıAdı =txtKullanıcı.Text,
                Şifre=txtŞifre.Text,
                OwnerId = DataBaseConnectionOptions.OwnerUserId
            };
            DBConnection.DbCon.Worker.Add(calisan);
            DBConnection.DbCon.SaveChanges();
        }
    }
}
