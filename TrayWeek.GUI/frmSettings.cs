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
        public frmSettings()
        {
            InitializeComponent();
            drpWeekStartDay.SelectedIndex = 0;
            drpFirstWeek.SelectedIndex = 0;
        }

        private void brnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
