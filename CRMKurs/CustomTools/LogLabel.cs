using System;
using System.Windows.Forms;
using CRMKurs.EntityClasses;

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

        private void LogLabel_Load(object sender, EventArgs e)
        {
            LabelName.Text = _log.Worker.KullaniciAdi;
            txtBAction.Text = _log.Action;
            LabelDate.Text = _log.Date.ToLongDateString();
        }
    }
}
