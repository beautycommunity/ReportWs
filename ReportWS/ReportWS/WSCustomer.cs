using kBeautyLibrary;
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
    public partial class WSCustomer : Form
    {
        public WSCustomer()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBrandDialog frm = new frmBrandDialog();
            frm.ShowDialog();

            if (frm.closedOK)
            {
                SearchPOS(frm.Brand);
            }
        }

        private void Myinit()
        {
            lsvSearch.LabelWrap = true;
            // Add Columns     
            lsvSearch.Columns.Add("ลำดับ", 50, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("รหัสสมาชิก", 80, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ชื่อสมาชิก", 100, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("แบนด์", 90, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("จำนวน", 80, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ยอด", 160, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ค่าเฉลี่ย", 60, HorizontalAlignment.Left);
        }

        private void SearchPOS(string Brand)
        {
            string SBrand = Brand;

            lsvSearch.Items.Clear();

            string strconn = @"Data Source=192.168.1.77,1434;Initial Catalog=MONA110601;User Id=sa;Password=0211;";

            if (SBrand.Length > 2)
            {
                string sql = "select arcode,arname,project,count(docno) as qty,sum(debtamount) as net ";
                sql += ",sum(debtamount)/count(docno) as avg from (select a.arcode, isnull(b.NAMETH, a.arname) as arname ";
                sql += ", docno, project, a.debtamount from cssaleorder a left join CSar b on a.arcode = b.code ";
                sql += "where a.CLOSEFLAG = 0 and a.docno like '%WS%' ";
                sql += "and(a.docno  like '5%' or a.docno  like '1%')) as a group by arcode,arname,project order by project, arcode";
                DataSet ds = cData.getDataSetWithQueryCommand(strconn, sql, 1000, true);

                if (ds.Tables[0].Rows.Count <= 0)
                {
                    cMessage.ErrorNoData();
                    return;
                }

                lsvSearch.addDataWithDataset(ds, true, false);
            }
            else
            {
                string sql = "select arcode,arname,project,count(docno) as qty,sum(debtamount) as net ";
                sql += ",sum(debtamount)/count(docno) as avg from (select a.arcode, isnull(b.NAMETH, a.arname) as arname ";
                sql += ", docno, project, a.debtamount from cssaleorder a left join CSar b on a.arcode = b.code ";
                sql += "where a.CLOSEFLAG = 0 and a.docno like '%WS%' AND PROJECT = '" + SBrand + "' ";
                sql += "and(a.docno  like '5%' or a.docno  like '1%')) as a group by arcode,arname,project order by project, arcode";
                DataSet ds = cData.getDataSetWithQueryCommand(strconn, sql, 1000, true);

                if (ds.Tables[0].Rows.Count <= 0)
                {
                    cMessage.ErrorNoData();
                    return;
                }

                lsvSearch.addDataWithDataset(ds, true, false);
            }
        }

        private void WSEmployee_Load(object sender, EventArgs e)
        {
            Myinit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuExportExcel_Click(object sender, EventArgs e)
        {
            lsvSearch.ExportToExcel("1,2,3,4,5,6,7");
        }
    }
}
