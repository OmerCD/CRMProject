using System;
using System.Linq;
using System.Windows.Forms;
using CRMKurs.EntityClasses;
using DesktopAppCRM;
using MySql.Data.MySqlClient;

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
            cmbxVeriTürü.Items.AddRange(ExtraField.FieldTypes);
            cbAlan.SelectedIndex = cbTür.SelectedIndex = cmbxVeriTürü.SelectedIndex= 0;
            RefreshTypeList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //PersonTypes pType = (from x in DBConnection.DbCon.PersonTypes where  x.OwnerId == DataBaseConnectionOptions.OwnerUserId && x.Isim==cbAlan.SelectedItem.ToString() select x).First();
            //if (pType == null)
            //{
            //    return;
            //}
            //var eField = new ExtraField
            //{
            //    ExtraName = txtİsim.Text,
            //    InputType = cbTür.SelectedItem.ToString(),
            //    ShowType = pType
            //};
            //DBConnection.DbCon.ExtraField.Add(eField);
            //DBConnection.DbCon.SaveChanges();
            DBConnection.QueryConnection.Open();
            var id = Guid.NewGuid().ToString(); 
            var tür = "Institution";
            if (cbTür.Text == "Kişi")
            {
                tür = "Person";
            }
            string tableQuery = $"INSERT INTO Owner1 (Id,DegerTabloAdi,TabloAdi,AlanAdi,VeriTuru) VALUES ('{id}','{txtİsim.Text}','{tür}','{cbAlan.Text}','{ExtraField.GetFieldTypeName(cmbxVeriTürü.SelectedIndex)}')";
            using (var cmd = new MySqlCommand(tableQuery, DBConnection.QueryConnection))
            {
                cmd.ExecuteNonQuery();
            }
            tableQuery = $"CREATE TABLE {txtİsim.Text+"_"+ DataBaseConnectionOptions.OwnerUserId} (Value {ExtraField.GetFieldTypeName(cmbxVeriTürü.SelectedIndex)}, ForeignId varchar(45))";
            using (var cmd = new MySqlCommand(tableQuery, DBConnection.QueryConnection))
            {
                cmd.ExecuteNonQuery();
            }
            DBConnection.QueryConnection.Close();
        }

        private void RefreshTypeList()
        {
            LVTypes.Items.Clear();
            DBConnection.QueryConnection.Open();
            string query =
                $"Select DegerTabloAdı,TabloAdi,AlanAdi,VeriTuru from Owner{DataBaseConnectionOptions.OwnerUserId}";
            using (var cmd = new MySqlCommand(query, DBConnection.QueryConnection))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var lvItem = new ListViewItem {Text = dr["DegerTabloAdi"].ToString()};
                        var tür = "Kişi";
                        switch (dr["TabloAdi"].ToString())
                        {
                            case "Institution":
                                tür = "Kurum";
                                break;
                        }
                        lvItem.SubItems.AddRange(new []{dr["AlanAdi"].ToString(),tür,ExtraField.GetFieldName(dr["VeriTuru"].ToString())});
                        LVTypes.Items.Add(lvItem);
                    }
                }
            }
            DBConnection.QueryConnection.Close();
        }
        private void cbTür_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTür.SelectedIndex)
            {
                case 0:
                    cbAlan.Items.Clear();
                    var types = (from x in DBConnection.DbCon.PersonTypes where x.OwnerId == DataBaseConnectionOptions.OwnerUserId select x.Isim).ToArray();
                    cbAlan.Items.AddRange(types);
                    break;
                case 1:
                    cbAlan.Items.Clear();
                    cbAlan.Items.Add("Standart");
                    break;
            }
            cbAlan.SelectedIndex = 0;
        }
    }
}
