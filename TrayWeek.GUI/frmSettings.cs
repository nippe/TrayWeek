using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayWeek.GUI
{
    public partial class frmSettings : Form
    {
        private string _weekDay = string.Empty;
        private string _firstWeekOfYear = string.Empty;

        public frmSettings()
        {
            InitializeComponent();
            drpWeekStartDay.SelectedIndex = 0;
            drpFirstWeek.SelectedIndex = 0;
        }

        private void brnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            _weekDay = drpWeekStartDay.Text;
            _firstWeekOfYear = drpWeekStartDay.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string WeekDay
        {
            get { return _weekDay; }
            set { _weekDay = value; }
        }

        public string FirstWeekOfYear
        {
            get { return _firstWeekOfYear; }
            set { _firstWeekOfYear = value; }
        }
    }
}
