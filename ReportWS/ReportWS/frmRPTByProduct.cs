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
    public partial class frmRPTByProduct : frmSub
    {

        string StrConn;
        string Brand;
        TextBox frmsql = new TextBox();
        TextBox frmbl = new TextBox();

        public frmRPTByProduct()
        {
            InitializeComponent();

            StrConn = "Data Source = 192.168.1.24,1833; Initial Catalog =cmd-bx; Persist Security Info = True; User ID = sa; Password = 0211";
            Brand = "BC";
        }

        public frmRPTByProduct(string _strconn, string _brand)
        {
            InitializeComponent();

            StrConn = _strconn;
            Brand = _brand;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmCSV_Click(object sender, EventArgs e)
        {
            lv.ExportToCsv(true, "");
        }

        private void tsmExcel_Click(object sender, EventArgs e)
        {
            lv.ExportToExcel("1");
        }

        private void tsbCondition_Click(object sender, EventArgs e)
        {
            try
            {
                frmRPTByProductCond frm = new frmRPTByProductCond(StrConn,Brand,ref frmsql,ref frmbl);
                frm.ShowDialog();

                if (frmbl.Text =="true")
                {
                    using (cWaitIndicator cw = new cWaitIndicator())
                    {
                        DataSet ds = new DataSet();

                        ds = cData.getDataSetWithQueryCommand(StrConn, frmsql.Text, 1000000, true);

                        //lv.addDataWithDataset(ds, true, true);

                        lv.Items.Clear();
                        ListViewItem LvItm = new ListViewItem();

                        for (int cnt = 0; cnt <= ds.Tables[0].Rows.Count - 1; cnt++)
                        {
                            LvItm = lv.Items.Add((cnt + 1).ToString());
                            int idx = lv.Items.IndexOf(LvItm);

                            lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[cnt]["productcode"].ToString());
                            lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[cnt]["productname"].ToString());
                            lv.Items[idx].SubItems.Add(decimal.Parse( ds.Tables[0].Rows[cnt]["qty"].ToString()).ToString("#,##0"));

                        }

                    }

                    MessageBox.Show("ดึงข้อมูลสำเร็จ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลสด\n" + ex.Message);
            }
        }
    }
}
