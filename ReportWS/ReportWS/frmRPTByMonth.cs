﻿using System;
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
    public partial class frmRPTByMonth : frmSub
    {
        string StrConn;
        string Brand;
        TextBox txtSql = new TextBox();
        TextBox txtBl = new TextBox();
        kbListView lsv = new kbListView();

        string sql;

        public frmRPTByMonth()
        {
            InitializeComponent();
            StrConn = "Data Source = 192.168.1.24,1833; Initial Catalog =cmd-bx; Persist Security Info = True; User ID = sa; Password = 0211";
            Brand = "BB";
        }

        public frmRPTByMonth(string _strconn,string _brand )
        {
            InitializeComponent();
            StrConn = _strconn;
            Brand = _brand;
        }


        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbCondition_Click(object sender, EventArgs e)
        {
            try
            {
                

                frmRPTByMonthCond frm = new frmRPTByMonthCond(StrConn, Brand,ref txtSql,ref txtBl);
                frm.ShowDialog();

                if (txtBl.Text == "true")
                {
                    sql = txtSql.Text;

                    using (cWaitIndicator cw = new cWaitIndicator())
                    {
                        DataSet ds = new DataSet();

                        ds = cData.getDataSetWithQueryCommand(StrConn, sql, 1000000, true);

                      
                        lv.Items.Clear();

                        ListViewItem LvItm = new ListViewItem();

                        for(int cnt= 0; cnt <= ds.Tables[0].Rows.Count - 1; cnt++ )
                        {
                            LvItm = lv.Items.Add((cnt+1).ToString());
                            int idx = lv.Items.IndexOf(LvItm);

                            lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[cnt]["docyear"].ToString());
                            lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[cnt]["docmonth"].ToString());
                            lv.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[cnt]["qty"].ToString()).ToString("#,##0"));
                            lv.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[cnt]["net"].ToString()).ToString("#,##0"));
                            lv.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[cnt]["avg"].ToString()).ToString("#,##0"));
                            lv.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[cnt]["cnt"].ToString()).ToString("#,##0"));

                        }

                        lsv.addDataWithDataset(ds, true, true);

                    }
                    MessageBox.Show("ดึงข้อมูลสำเร็จ");
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลสด\n" + ex.Message);
            }
        }

        private void tsmCSV_Click(object sender, EventArgs e)
        {
            lsv.ExportToCsv(true, "");  
          
        }

        private void tsmExcel_Click(object sender, EventArgs e)
        {
            lsv.ExportToExcel();
        }
    }
}
