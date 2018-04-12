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
    public partial class frmRPTByProductCond : frmDialogReportCondition
    {
        string StrConn;
        string Brand;
        TextBox txtwhcode = new TextBox();
        TextBox txtBl = new TextBox();

        TextBox frmsql = new TextBox();
        TextBox frmbl = new TextBox();

        public frmRPTByProductCond()
        {
            InitializeComponent();

            StrConn = "Data Source = 192.168.1.24,1833; Initial Catalog =cmd-bx; Persist Security Info = True; User ID = sa; Password = 0211";
            Brand = "BC";

            frmbl.Text = "false";
            frmsql.Text = "";
        }

        public frmRPTByProductCond(string _strconn, string _brand, ref TextBox _txtsql, ref TextBox _txtbl)
        {
            InitializeComponent();

            StrConn = _strconn;
            Brand = _brand;
            frmsql = _txtsql;

            frmbl = _txtbl;
        }

        private void btndellAll_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
        }

        private void btndell_Click(object sender, EventArgs e)
        {
            lv.SelectedItems[0].Remove();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtwhcode.Text = "";
            frmProduct frm = new frmProduct(StrConn,Brand,ref txtwhcode,ref txtBl);
            frm.ShowDialog();

            if (txtBl.Text == "true")
            {
                string strWhcode = txtwhcode.Text;
                string[] ArWhcode;
                string[] ArWhname;

                ArWhcode = strWhcode.Split(',');

                for(int i=0; i<= ArWhcode.Length -1;i++)
                {
                    ListViewItem LvItm;
                    ArWhname = ArWhcode[i].Split(':');
                    LvItm = lv.Items.Add(ArWhname[0]);
                    int idx = lv.Items.IndexOf(LvItm);
                    lv.Items[idx].SubItems.Add(ArWhname[1]);

                }

            }
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            //base.btnSubmit_Click(sender, e);
            frmbl.Text = "false";

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

            if(lv.Items.Count>0)
            {
                for (int i = 0; i <= lv.Items.Count - 1; i++)
                {
                    if(i==0)
                    {
                        whstr = "'" + lv.Items[i].SubItems[0].Text + "'";
                    }
                    else
                    {
                        whstr = whstr +",'" + lv.Items[i].SubItems[0].Text + "'";
                    }
                    
                   
                }

                whstr = " and b.productcode in (" + whstr + ")";
            }
            else
            {
                whstr = "";
            }
            sql = @"select productcode,productname,sum(b.QUANTITY) as qty,sum(b.AMOUNT) as net 
                    from [192.168.1.77,1434].mona110601.dbo.cssaleorder a
                    left join [192.168.1.77,1434].mona110601.dbo.cssaleordersub b on a.DOCNO = b.DOCno
                    where a.CLOSEFLAG = 0
                    and a.docno like '%WS%'
                    and b.productcode <> '.'
                    and a.docdate between '"+ dtpS.getDateOnlyForSql() +"' and '"+ dtpF.getDateOnlyForSql() + @"' 
                    and " + idBrand + whstr + @"
                    group by productcode,productname
                    order by qty desc,PRODUCTCODE";

            frmbl.Text = "true";
            frmsql.Text = sql;

            this.Close();
        }
    }
}
