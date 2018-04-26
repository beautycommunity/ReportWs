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
    public partial class FormMain : kBeautyLibrary.frmSub
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuOffline_Click(object sender, EventArgs e)
        {
            frmRPTByDetail frm_Detail = new frmRPTByDetail();
            frm_Detail.ShowDialog();
        }

        private void รายงานรายปToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPTByYEAR frm_Year = new frmRPTByYEAR();
            frm_Year.ShowDialog();
        }

        private void รายงานตามลกคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPTByCustomer frm_Cus = new frmRPTByCustomer();
            frm_Cus.ShowDialog();
        }

        private void รายงานตามพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPTByEmployee frm_Emp = new frmRPTByEmployee();
            frm_Emp.ShowDialog();
        }

        private void รายงานตามสาขาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPTByWH frm_WH = new frmRPTByWH();
            frm_WH.ShowDialog();
        }
    }
}
