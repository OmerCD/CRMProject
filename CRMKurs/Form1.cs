using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMKurs;
using CRMKurs.EntityClasses;
using CRMKurs.Migrations;

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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                          "\\CRM\\settings";
            int NumberOfRetries = 3;
            int DelayOnRetry = 1000;

                try
                {
                    using (
                        StreamWriter sw =
                            new StreamWriter(path))
                    {
                        for (int i = 0; i <= NumberOfRetries; i++)
                        {

                            sw.Write(Cipher.Encrypt("$" + boss.KullanıcıAdı + "ô" + boss.OwnerId + "$",
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
            Color c = ((PictureBox)sender).BackColor;
            ChangeThemeColors(c);
        }
        void ChangeThemeColors(Color color)
        {
            StripMenu.BackColor = color;
        }
        void ChangeColorOfText(object sender, EventArgs e)
        {
            ToolStripMenuItem item = ((ToolStripMenuItem)sender);
            item.ForeColor = item.ForeColor == Color.Black ? Color.White : Color.Black;

        }

        private void takvimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.ShowDialog();
        }

        private void öğretimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kişi.frmKişi frm = new Kişi.frmKişi();
            frm.ShowDialog();
        }

        private void opsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void okulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Okul.frmKurum();
            frm.ShowDialog();
        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            //test asd = new test();
            //asd.Down();
        }

        private void MainCRMWindow_Load(object sender, EventArgs e)
        {
            //var frm = new frmKullanıcıGiriş();
            //DialogResult dR = frm.ShowDialog();
            //switch (dR)
            //{
            //    case DialogResult.Yes:
            //        WriteCipher(frm._bossInformation);
            //        break;
            //    case DialogResult.Cancel:
            //        Application.Exit();
            //        break;
            //}
        }
    }
}
