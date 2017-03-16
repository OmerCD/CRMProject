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

namespace CRMKurs.DebugForms
{
    public partial class AddDebugForm : Form
    {
        enum DebugClasses
        {
            Person,
            MainBoss
        }
        public AddDebugForm()
        {
            InitializeComponent();
        }

        private void AddDebugForm_Load(object sender, EventArgs e)
        {
            foreach (var name in Enum.GetNames(typeof(DebugClasses)))
            {
                cBDebugList.Items.Add(name);
            }
            cBDebugList.SelectedIndex = 0;
        }

        private void cBDebugList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((DebugClasses)cBDebugList.SelectedIndex)
            {
                case DebugClasses.Person:
                    PropertyGridDebugClass.SelectedObject = new Person();
                    break;
                case DebugClasses.MainBoss:
                    PropertyGridDebugClass.SelectedObject = new MainBoss();
                    break;
            }
        }
    }
}
