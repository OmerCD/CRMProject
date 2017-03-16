using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMKurs.EntityClasses;
using CRMKurs.EntityClasses.Abstract;
using CRMKurs.Kişi;
using CRMKurs.Okul;

namespace CRMKurs.CustomTools
{
    public partial class LogLabel : UserControl
    {
        private Log _log;
        public LogLabel(Log log)
        {
            InitializeComponent();
            _log = log;
        }
        private void PersonName_Click(object sender, EventArgs e)
        {

        }

        private void LogLabel_Load(object sender, EventArgs e)
        {
            LabelName.Text = _log.Worker.KullanıcıAdı;
            txtBAction.Text = _log.Action;
            LabelDate.Text = _log.Date.ToLongDateString();
        }
    }
}
