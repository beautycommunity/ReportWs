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
            WSDetail frm_Detail = new WSDetail();
            frm_Detail.ShowDialog();
        }

        private void รายงานรายปToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WSYEAR frm_Year = new WSYEAR();
            frm_Year.ShowDialog();
        }

        private void รายงานตามลกคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WSCustomer frm_Cus = new WSCustomer();
            frm_Cus.ShowDialog();
        }

        private void รายงานตามพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WSEmployee frm_Emp = new WSEmployee();
            frm_Emp.ShowDialog();
        }
    }
}
