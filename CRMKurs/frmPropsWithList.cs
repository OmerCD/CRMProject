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
        public frmPropsWithList()
        {
            InitializeComponent();
        }

        private void frmPropsWithList_Load(object sender, EventArgs e)
        {
            propertyGridMVCList1.SelectedTable = new PersonTypes();
        }
    }
}
