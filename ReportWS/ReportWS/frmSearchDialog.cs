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
    public partial class frmSearchDialog : kBeautyLibrary.frmDialogReportCondition
    {
        //public ListView lsvItemRet;
        //public ListView lsvStaffRet;
        public string dateStart;
        public string dateEnd;
        public bool closedOK = false;

        public frmSearchDialog()
        {
            InitializeComponent();
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
            dateStart = dtpSdate.getDateOnlyForSql();
            dateEnd = dtpEdate.getDateOnlyForSql();
        }
    }
}
