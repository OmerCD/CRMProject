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
    public partial class frmPropsWithList : Form
    {
        public frmPropsWithList(object selectedObject,string title)
        {
            InitializeComponent();
            propertyGridMVCList1.SelectedTable = selectedObject;
            labelTitle.Text = title;
            lblTitle.Text = title;
        }

        private void frmPropsWithList_Load(object sender, EventArgs e)
        {
            //propertyGridMVCList1.SelectedTable = new PersonTypes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
