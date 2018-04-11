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
    }
}
