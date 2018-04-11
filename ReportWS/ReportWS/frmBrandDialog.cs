using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportWS
{
    public partial class frmBrandDialog : kBeautyLibrary.frmDialogReportCondition
    {
        public string Brand;
        public bool closedOK = false;

        public frmBrandDialog()
        {
            InitializeComponent();
        }

        private void frmBrandDialog_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("BB");
            comboBox.Items.Add("BC");
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            SetReturn();
            //base.btnSubmit_Click(sender, e);
            this.Close();
        }

        private void SetReturn()
        {
            closedOK = true;
            Brand = comboBox.Text;
        }
    }
}
