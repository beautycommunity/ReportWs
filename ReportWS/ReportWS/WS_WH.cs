using kBeautyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportWS
{
    public partial class WS_WH : Form
    {
        string StrConn;
        string Brand;

        public WS_WH()
        {
            InitializeComponent();
            StrConn = "Data Source = 192.168.1.24,1833; Initial Catalog =cmd-bx; Persist Security Info = True; User ID = sa; Password = 0211";
            Brand = "BC";
        }

        public WS_WH(string _strconn, string _brand)
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

        private void WS_WH_Load(object sender, EventArgs e)
        {
            Myinit();

        }

        private void Myinit()
        {
            lsvSearch.LabelWrap = true;
            // Add Columns     
            lsvSearch.Columns.Add("ลำดับ", 50, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ชื่อสาขา", 200, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("แบนด์", 90, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("จำนวน", 80, HorizontalAlignment.Right);
            lsvSearch.Columns.Add("ยอด", 160, HorizontalAlignment.Right);
        }

        private void SearchPOS(string dateStart, string dateEnd)
        {
            try
            {
                using (new cWaitIndicator())
                {
                    Thread.Sleep(100);

                    lsvSearch.Items.Clear();

                    string strconn = StrConn;

                    string sql = @"select whcode,whname,PROJECT ,count(docno) as qty ,CONVERT(varchar, CAST(sum(debtamount) AS money), 1) as net from (
                         select substring(a.DOCNO,1,4) as whcode,b.MYNAMETH as whname,a.PROJECT  ,docno ,debtamount
                         from [192.168.1.77,1434].[MONA110601].dbo.cssaleorder a
                         left join [192.168.1.77,1434].[MONA110601].dbo.cswarehouse b on substring(a.DOCNO,1,4) = b.code
                         where a.CLOSEFLAG = 0
                         and a.docno like '%WS%'
                         and (a.docno like '5%' or a.docno like '1%')
                         AND A.DOCDATE BETWEEN '" + dateStart + @"' AND '" + dateEnd + @"'
                         AND A.PROJECT = '" + Brand + @"'
                         ) as a
                         group by whcode, whname, PROJECT
                         order by PROJECT ,whcode";

                    DataSet ds = cData.getDataSetWithQueryCommand(strconn, sql, 1000, true);

                    if (ds.Tables[0].Rows.Count <= 0)
                    {
                        cMessage.ErrorNoData();
                        //return;
                    }

                    lsvSearch.addDataWithDataset(ds, true, false);

                }
            }
            catch 
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuExportExcel_Click(object sender, EventArgs e)
        {
            lsvSearch.ExportToExcel("1,2,3,4,5");
        }
    }
}
