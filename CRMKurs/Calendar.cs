using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarTool=System.Windows.Forms.Calendar;

namespace CRMKurs
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
           
        }

        private void MonthView_SelectionChanged(object sender, EventArgs e)
        {
            MainCalendar.SetViewRange(MonthView.SelectionStart, MonthView.SelectionEnd);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var testItems = MainCalendar.Items;
        }
    }
}
