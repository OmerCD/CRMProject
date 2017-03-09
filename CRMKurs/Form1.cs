using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMKurs.Migrations;

namespace CRMKurs
{

    public partial class MainCRMWindow : Form
    {
        
        public MainCRMWindow()
        {
            InitializeComponent();
            DBConnection.DbCon = new ModelBuild();
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorPanel.Visible = !ColorPanel.Visible;
        }
        void ChangeThemeColor(object sender,EventArgs e)
        {
            Color c = ((PictureBox)sender).BackColor;
            ChangeThemeColors(c);
        }
        void ChangeThemeColors(Color color)
        {
            StripMenu.BackColor = color;
        }
        void ChangeColorOfText(object sender,EventArgs e)
        {
            ToolStripMenuItem item = ((ToolStripMenuItem)sender);
            item.ForeColor=item.ForeColor==Color.Black?Color.White:Color.Black;

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
            var frm = new Okul.frmOkul();
            frm.ShowDialog();
        }
        
        private void DropButton_Click(object sender, EventArgs e)
        {
            //test asd = new test();
            //asd.Down();
        }
    }
}
