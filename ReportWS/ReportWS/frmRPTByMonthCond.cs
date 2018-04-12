using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using kBeautyLibrary;

namespace ReportWS
{
    public partial class frmRPTByMonthCond : frmDialogReportCondition
    {
       
        string StrConn;
        string Brand;
        TextBox txtSql = new TextBox();
        TextBox txtBl = new TextBox();

        public frmRPTByMonthCond()
        {
            InitializeComponent();

            StrConn="";
            Brand = "BB";
            txtSql.Text = "";
            txtBl.Text = "false";

            cmbYear.Items.Add(DateTime.Now.Year);
            cmbYear.Items.Add(DateTime.Now.Year - 1);
            cmbYear.Items.Add(DateTime.Now.Year - 2);
            cmbYear.Items.Add(DateTime.Now.Year - 3);

            cmbYear.SelectedIndex = 0;


        }

        public frmRPTByMonthCond(string _strconn,string _brand,ref TextBox _txtsql,ref TextBox _txtbl)
        {
            InitializeComponent();

            StrConn = _strconn;
            Brand = _brand;
            txtSql = _txtsql;
            txtBl = _txtbl;

            cmbYear.Items.Add(DateTime.Now.Year);
            cmbYear.Items.Add(DateTime.Now.Year - 1);
            cmbYear.Items.Add(DateTime.Now.Year - 2);
            cmbYear.Items.Add(DateTime.Now.Year - 3);

            cmbYear.SelectedIndex = 0;

            txtBl.Text = "false";
        }


        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            //base.btnSubmit_Click(sender, e);
            string sql = "";
            string idBrand = "";
            string whstr = "";

            if (Brand.ToLower() == "bb")
            {
                idBrand = "a.docno  like '1%'";
            }
            else if (Brand.ToLower() == "bc")
            {
                idBrand = "a.docno  like '5%'";
            }
            else
            {
                idBrand = "a.docno  like '7%'";
            }

            if (chkAll.Checked == false)
            {
                whstr = " and a.docyear = '" + cmbYear.Text + "'";
            }

            sql = @"select a.*,b.cnt 
                        from ( 
                        select docyear, docmonth, count(docno) as qty,sum(debtamount) as net, 
                        sum(debtamount) / count(docno) as avg
                        from(
                        select year(docdate) as docyear, month(docdate) as docmonth,*
                        from [192.168.1.77,1434].[mona110601].dbo.cssaleorder as a
                         where a.CLOSEFLAG = 0
                        and a.docno like '%WS%'
                        and " + idBrand + @"
                        ) as a
                        group by docyear,docmonth
                        ) as a
                        left join(
                        select docyear, docmonth, count(arcode) as cnt from(
                          select docyear, docmonth, arcode from(
                          select year(docdate) as docyear, month(docdate) as docmonth, arcode
                           from [192.168.1.77,1434].[mona110601].dbo.cssaleorder as a
                           where a.CLOSEFLAG = 0
                          and a.docno like '%WS%'
                          and " + idBrand + @"
                          ) as a
                          group by docyear, docmonth, arcode) as a
                        group by docyear,docmonth ) as b on a.docyear = b.docyear and a.docmonth = b.docmonth
                        where a.docyear is not null " + whstr + " order by a.docyear,a.docmonth";


            txtBl.Text = "true";
            txtSql.Text = sql;
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            txtBl.Text = "false";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลสด\n" + ex.Message);
            }
        }
    }
}
