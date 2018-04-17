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
    public partial class WSDetail : Form
    {
        string StrConn;
        string Brand;

        public WSDetail()
        {
            InitializeComponent();
            StrConn = "Data Source = 192.168.1.24,1833; Initial Catalog =cmd-bx; Persist Security Info = True; User ID = sa; Password = 0211";
            Brand = "BC";
        }

        public WSDetail(string _strconn, string _brand)
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
            lsvSearch.Columns.Add("วัน/เดือน/ปี", 120, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("เลขที่เอกสาร", 100, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ยอด", 90, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("รหัสสมาชิก", 80, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ชื่อสมาชิก", 160, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("รหัสสาขา", 60, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ชื่อสาขา", 150, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("รหัสพนักงาน", 80, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ชื่อพนักงาน", 150, HorizontalAlignment.Left);
        }

        private void SearchPOS(string dateStart, string dateEnd)
        {
            using (new cWaitIndicator())
            {
                Thread.Sleep(100);
                //string[] itemQuery = new string[] { };

                //string Sdate = dateStart;
                DateTime FormatSdate = DateTime.Parse(dateStart);
                DateTime FormatEdate = DateTime.Parse(dateEnd);
                string Sdate = FormatSdate.ToString("dd/MM/yyyy");
                string Edate = FormatEdate.ToString("dd/MM/yyyy");

                //lsvSearch.Items.Clear();

                string strconn = StrConn;

                string sql = @"WITH ANS AS (select convert(varchar(10),a.docdate,103) docdate1, a.docno,
                            a.DEBTAMOUNT,
                            a.arcode,c.NAMETH as arname,right(a.salecode, 4) as whcode,d.MYNAMETH as whname,b.stcode ,e.MYNAMETH as stname
                            from [192.168.1.77,1434].[MONA110601].dbo.cssaleorder a ";

                if (Brand == "BC")
                {
                    sql += "left join [192.168.1.220].[dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno ";
                }
                else if (Brand == "BB")
                {
                    sql += "left join [dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno ";
                }

                sql += @"left join [192.168.1.77,1434].[MONA110601].dbo.csar c on a.arcode = c.code
                            left join [192.168.1.77,1434].[MONA110601].dbo.CSUSER d on a.SALECODE = d.code
                            left join [192.168.1.77,1434].[MONA110601].dbo.CSUSER e on b.stcode = e.code where a.CLOSEFLAG = 0 and a.docno
                            like '%WS%' and a.docno like '1%' union all select convert(varchar(10),a.docdate,103) docdate1, 
                            a.docno,a.DEBTAMOUNT,a.arcode,c.NAMETH as arname, right(a.salecode,4) as whcode,d.MYNAMETH as whname,b.stcode ,
                            e.MYNAMETH as stname from[192.168.1.77,1434].[MONA110601].dbo.cssaleorder a ";
                            
                if(Brand == "BC")
                {
                    sql += "left join [dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno ";
                }
                else if(Brand == "BB")
                {
                    sql += "left join [192.168.1.24,1833].[dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno ";
                }  

                            
                sql += @"left join [192.168.1.77,1434].[MONA110601].dbo.csar c on a.arcode = c.code
                            left join [192.168.1.77,1434].[MONA110601].dbo.CSUSER d on a.SALECODE = d.code
                            left join [192.168.1.77,1434].[MONA110601].dbo.CSUSER e on b.stcode = e.code where a.CLOSEFLAG = 0 and a.docno like '%WS%' and a.DEBTAMOUNT> 0 )
                            
                            select docno,
                            CONVERT(varchar, CAST(debtamount AS money), 1) AS NET,
                            arcode, arname, whcode, whname, stcode, stname FROM ANS "; 
                if(Brand == "BC")
                {
                    sql += "WHERE whcode LIKE '5%' ";
                }
                else if(Brand == "BB")
                {
                    sql += "WHERE whcode LIKE '1%' ";
                }                                                                                                         
                            sql += "AND docdate1 BETWEEN '"+ Sdate + "' AND '"+ Edate + "' ORDER BY docdate1";

                DataSet ds = cData.getDataSetWithQueryCommand(strconn, sql, 1000, true);

                if (ds.Tables[0].Rows.Count <= 0)
                {
                    cMessage.ErrorNoData();
                    return;
                }

                lsvSearch.addDataWithDataset(ds, true, false);
            }
        }

        private void WSDetail_Load(object sender, EventArgs e)
        {
            Myinit();
        }

        private void mnuExportExcel_Click(object sender, EventArgs e)
        {
            lsvSearch.ExportToExcel("1,2,3,4,5,6,7,8,9,10");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
