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
    public partial class frmProduct : frmDialogReportCondition
    {
        string StrConn;
        string Brand;
        TextBox txtwhcode = new TextBox();
        TextBox txtBl = new TextBox();

        Boolean bl;

        public frmProduct()
        {
            InitializeComponent();
            StrConn = "Data Source = 192.168.1.24,1833; Initial Catalog =cmd-bx; Persist Security Info = True; User ID = sa; Password = 0211";
            Brand = "BC";

            bl = false;
            txtBl.Text = "false";
            txtwhcode.Text = "";
        }

        public frmProduct(string _strconn, string _brand,ref TextBox _txtwhcode,ref TextBox _txtbl)
        {
            InitializeComponent();
            StrConn = _strconn;
            Brand = _brand;
            txtwhcode= _txtwhcode;

            bl = false;
            txtBl = _txtbl;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                mpsearch(txt_search.Text);
            }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_search.Text != "")
                {
                    mpsearch(txt_search.Text);
                }

            }
        }

        private void mpsearch(string _mpcode)
        {
            try
            {
                string sql = "";
                
                sql = @"select mpcode,fullname as mpname from [cmd-bx]..mas_mp 
                    where mpcode like '%" + _mpcode + @"%'
                    or fullname like '%" + _mpcode + "%'";
                DataSet mp = new DataSet();
                mp = cData.getDataSetWithQueryCommand(StrConn, sql, 1000000, true);
                lv.addDataWithDataset(mp, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลสด\n" + ex.Message);
            }
        }

        private void lbl_all_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            for (int i = 0; i <= lv.Items.Count - 1; i++)
            {
                lv.Items[i].Checked = !bl;
            }

            bl = !bl;
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            //base.btnSubmit_Click(sender, e);
            txtBl.Text = "false";

            try
            {

                for (int i = 0; i <= lv.Items.Count - 1; i++)
                {
                    if (lv.Items[i].Checked==true)
                    {
                        if(txtwhcode.Text == "")
                        {
                            txtwhcode.Text =  lv.Items[i].SubItems[1].Text + ":"+ lv.Items[i].SubItems[2].Text;
                        }
                        else
                        {
                            txtwhcode.Text = txtwhcode.Text  +","+ lv.Items[i].SubItems[1].Text + ":" + lv.Items[i].SubItems[2].Text;
                        }
                    }
                }

                if (txtwhcode.Text == "")
                {
                    txtBl.Text = "false";
                }
                else
                {
                    txtBl.Text = "true";
                }

                this.Close();
            }
            catch (Exception ex)
            {
                txtBl.Text = "false";
                MessageBox.Show("เกิดข้อผิดพลสด\n" + ex.Message);
            }

        }


    }
        
}
