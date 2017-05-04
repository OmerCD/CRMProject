using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CRMKurs.CustomTools;
using CRMKurs.EntityClasses;

namespace CRMKurs
{

    public partial class MainCRMWindow : Form
    {

        public MainCRMWindow()
        {
            InitializeComponent();
        }
        void WriteCipher(MainBoss boss)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                          "\\CRM\\settings";
            var NumberOfRetries = 3;
            var DelayOnRetry = 1000;

                try
                {
                    using (
                        var sw =
                            new StreamWriter(path))
                    {
                        for (var i = 0; i <= NumberOfRetries; i++)
                        {

                            sw.Write(Cipher.Encrypt("$" + boss.KullaniciAdi + "ô" + boss.OwnerId + "$",
                                "Mr. Poopybutthole"));
                            

                        }
                        sw.Close();

                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);

                Thread.Sleep(DelayOnRetry);
                }
            
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorPanel.Visible = !ColorPanel.Visible;
        }
        void ChangeThemeColor(object sender, EventArgs e)
        {
            var c = ((PictureBox)sender).BackColor;
            ChangeThemeColors(c);
        }
        void ChangeThemeColors(Color color)
        {
            StripMenu.BackColor = color;
        }
        void ChangeColorOfText(object sender, EventArgs e)
        {
            var item = ((ToolStripMenuItem)sender);
            item.ForeColor = item.ForeColor == Color.Black ? Color.White : Color.Black;

        }

        private void takvimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clndr = new Calendar();
            clndr.ShowDialog();
        }

        private void öğretimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personToSend = new Person {PersonTypes = DBConnection.DbCon.PersonTypes.First(x=>x.Isim=="Ögrenci")};
            using (var frm = new frmPropsWithList(personToSend, "Öğrenci"))
            {
                frm.ShowDialog();
            }
        }

        private void opsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void okulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmPropsWithList(new Institution(), "Okul"))
            {
                frm.ShowDialog();
            }
        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            //test asd = new test();
            //asd.Down();
        }

        private void MainCRMWindow_Load(object sender, EventArgs e)
        {
            new DBConnection();
            var frm = new frmKullanıcıGiriş();
            var dR = frm.ShowDialog();
            switch (dR)
            {
                case DialogResult.Yes:
                    WriteCipher(frm._bossInformation);
                    break;
                case DialogResult.Cancel:
                    Application.Exit();
                    break;
            }
            //var personToSend =
            //    DBConnection.DbCon.Person.FirstOrDefault(
            //        x => x.PersonTypes.Isim == "Ögretmen");
            //var extraTest = new ExtraFieldController(personToSend);
            //extraTest.AddValue("testValue", personToSend.Id);

            //for (int i = 0; i < 5; i++)
            //{
            //    var logTest = new Log
            //    {
            //        Action = "Test " + i,
            //        Worker = new Worker
            //        {
            //            EMail = "asd" + i + "@asd.com",
            //            KullaniciAdi = "KAd" + i,
            //            Statu = Worker.Status.Kullanıcı,
            //            Şifre = "testPass" + i
            //        }
            //    };
            //    DBConnection.DbCon.Logs.Add(logTest);
            //}

            DBConnection.DbCon.SaveChanges();
            //LoadLogs();
        }

        void LoadLogs()
        {
            var logs = new LogControl().GetLast(20);
            if (logs == null) return;
            foreach (var log in logs)
            {
                PanelLogs.Controls.Add(new LogLabel(log));
            }
        }
        void CreateLogControls(Log[] arr)
        {
            
        }
        private void ColorPanel_LostFocus(object sender, EventArgs e)
        {
            ColorPanel.Hide();
        }

        private void kişiTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmPropsWithList(new PersonTypes(), "Kişi Türleri"))
            {
                frm.ShowDialog();
            }
        }

        private void ColorPanel_MouseLeave(object sender, EventArgs e)
        {
            if (ColorPanel.Visible)
            {
                if (!ColorPanel.RectangleToScreen(ColorPanel.DisplayRectangle).Contains(MousePosition))
                {
                    ColorPanel.Hide();
                }
            }
        }

        private void öğretmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personToSend = new Person { PersonTypes = DBConnection.DbCon.PersonTypes.First(x => x.Isim == "Ögretmen") };
            using (var frm = new frmPropsWithList(personToSend, "Öğretmenler"))
            {
                frm.ShowDialog();
            }
        }

        private void teklifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmPropsWithList(new Offer(), "Teklifler"))
            {
                frm.ShowDialog();
            }
        }

        private void ekstraAlanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmExtraField())
            {
                frm.ShowDialog();
            }
        }
    }
}
