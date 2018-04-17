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
        string StrConn;
        string Brand;

        public WSCustomer()
        {
            InitializeComponent();
            StrConn = "Data Source = 192.168.1.24,1833; Initial Catalog =cmd-bx; Persist Security Info = True; User ID = sa; Password = 0211";
            Brand = "BC";
        }

        public WSCustomer(string _strconn, string _brand)
        {
            InitializeComponent();
            StrConn = _strconn;
            Brand = _brand;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSearchDialog frm = new frmSearchDialog();
            frm.ShowDialog();

            if (frm.closedOK)
            {
                SearchPOS(frm.dateStart, frm.dateEnd);
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
            lsvSearch.Columns.Add("ยอด", 100, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ค่าเฉลี่ย", 100, HorizontalAlignment.Left);
        }

        private void SearchPOS(string dateStart, string dateEnd)
        {
            lsvSearch.Items.Clear();

            string strconn = StrConn;

            string sql = @"select arcode,arname,project,count(docno) as qty,CONVERT(varchar, CAST(sum(debtamount) AS money), 1) as net ,
                         CONVERT(varchar, CAST(sum(debtamount)/count(docno) AS money), 1) as avg
                         from (
                         select a.arcode,isnull(b.NAMETH,a.arname) as arname,docno,project,a.debtamount from [192.168.1.77,1434].[MONA110601].dbo.cssaleorder a
                         left join [192.168.1.77,1434].[MONA110601].dbo.CSar b on a.arcode = b.code
                         where a.CLOSEFLAG = 0
                         and a.docno like '%WS%'
                         and (a.docno  like '5%' or a.docno  like '1%') ";
            sql += "AND project = '" + Brand + "' ";
            sql += "AND a.DOCDATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' ";
                         sql += @") as a
                         group by arcode,arname,project
                         order by project,arcode";

            DataSet ds = cData.getDataSetWithQueryCommand(strconn, sql, 1000, true);

            if (ds.Tables[0].Rows.Count <= 0)
            {
                cMessage.ErrorNoData();
                return;
            }

            lsvSearch.addDataWithDataset(ds, true, false);
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
