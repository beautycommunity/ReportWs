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
    public partial class WSYEAR : Form
    {
        public WSYEAR()
        {
            InitializeComponent();
        }

        private void WSYEAR_Load(object sender, EventArgs e)
        {
            Myinit();
            SearchPOS();
        }

        private void Myinit()
        {
            lsvSearch.LabelWrap = true;
            // Add Columns     
            lsvSearch.Columns.Add("ลำดับ", 50, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ปี", 50, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("จำนวน", 50, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ยอด", 150, HorizontalAlignment.Left);
            lsvSearch.Columns.Add("ค่าเฉลี่ย", 150, HorizontalAlignment.Left);
        }

        private void SearchPOS()
        {
            //string[] itemQuery = new string[] { };

            //string Sdate = dateStart;
            //DateTime FormatSdate = DateTime.Parse(dateStart);
            //DateTime FormatEdate = DateTime.Parse(dateEnd);
            //string Sdate = FormatSdate.ToString("dd/MM/yyyy");
            //string Edate = FormatEdate.ToString("dd/MM/yyyy");

            //lsvSearch.Items.Clear();

            string strconn = @"Data Source=192.168.1.77,1434;Initial Catalog=MONA110601;User Id=sa;Password=0211;";

            string sql = "select docyear,count(docno) as qty,sum(debtamount) as net, sum(debtamount)/count(docno) as avg ";
            sql += "from (select year(docdate) as docyear,* from  cssaleorder as a ";
            sql += "where a.CLOSEFLAG = 0 and a.docno like '%WS%' and (a.docno  like '5%' or a.docno  like '1%')) as a ";
            sql += "group by docyear";

            DataSet ds = cData.getDataSetWithQueryCommand(strconn, sql, 1000, true);

            if (ds.Tables[0].Rows.Count <= 0)
            {
                cMessage.ErrorNoData();
                return;
            }

            lsvSearch.addDataWithDataset(ds, true, false);
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
