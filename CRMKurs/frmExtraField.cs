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
using DesktopAppCRM;

namespace CRMKurs
{
    public partial class frmExtraField : Form
    {
        public frmExtraField()
        {
            InitializeComponent();
        }

        private void frmExtraField_Load(object sender, EventArgs e)
        {
            cbTür.Items.AddRange(ExtraField.FieldTypes);
            var types = (from x in DBConnection.DbCon.PersonTypes where x.OwnerId == DataBaseConnectionOptions.OwnerUserId select x.Name).ToArray();
            cbAlan.Items.AddRange(types);
            cbTür.SelectedIndex = cbAlan.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonTypes pType = (from x in DBConnection.DbCon.PersonTypes where  x.OwnerId == DataBaseConnectionOptions.OwnerUserId && x.Name==cbAlan.SelectedItem.ToString() select x).First();
            if (pType == null)
            {
                return;
            }
            var eField = new ExtraField
            {
                Name = txtİsim.Text,
                InputType = cbTür.SelectedItem.ToString(),
                ShowType = pType
            };
            DBConnection.DbCon.ExtraField.Add(eField);
            DBConnection.DbCon.SaveChanges();
        }
    }
}
