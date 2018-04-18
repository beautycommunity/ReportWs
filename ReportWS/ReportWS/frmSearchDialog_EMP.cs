﻿using kBeautyLibrary;
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
    public partial class frmSearchDialog_EMP : kBeautyLibrary.frmDialogReportCondition
    {
        public ListView lsvItemRet;

        public string check;
        string StrConn;
        string Brand;
        public string txtwhcode;
        TextBox txtBl = new TextBox();
        public string dateStart;
        public string dateEnd;
        public bool closedOK = false;
        Boolean bl;

        public frmSearchDialog_EMP(string _StrConn, string _Brand)
        {
            InitializeComponent();
            StrConn = _StrConn;
            bl = false;
            Brand = _Brand;
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            SetReturn();
            //base.btnSubmit_Click(sender, e);
            this.Close();
        }

        private void SetReturn()
        {
            closedOK = true;
            dateStart = kbDateTimePicker2.getDateOnlyForSql();
            dateEnd = kbDateTimePicker1.getDateOnlyForSql();

            txtBl.Text = "false";
            for (int i = 0; i <= lsvProducts2.Items.Count - 1; i++)
            {
                if (lsvProducts2.Items[i].Checked == true)
                {
                    if (txtwhcode == "")
                    {
                        txtwhcode = lsvProducts2.Items[i].SubItems[0].Text;
                    }
                    else
                    {
                        txtwhcode = txtwhcode + "','" + lsvProducts2.Items[i].SubItems[0].Text;
                    }
                }
            }

            if (txtwhcode == "")
            {
                txtBl.Text = "false";
            }
            else
            {
                txtBl.Text = "true";
            }
        }

        private void frmSearchDialog_EMP_Load(object sender, EventArgs e)
        {
            Myinit();

            lsvProducts2.Items.Clear();

            string strconn = StrConn;

            string sql = @"select stcode,stname
                           from (
                           select b.stcode,isnull(b.stname,'') as stname,a.docno,project,a.debtamount 
                           from [192.168.1.77,1434].[MONA110601].dbo.cssaleorder a ";
            if (Brand == "BC")
            {
                sql += "left join [192.168.1.220].[dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno ";
            }
            else if(Brand == "BB")
            {
                sql += "left join [dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno ";
            }
            sql += @"where a.CLOSEFLAG = 0
                           and a.docno like '%WS%'
                           and (a.docno  like '1%')
                           union all
                           select b.stcode,isnull(b.stname,'') as stname,a.docno,project,a.debtamount 
                           from [192.168.1.77,1434].[MONA110601].dbo.cssaleorder a ";
            if (Brand == "BC")
            {
                sql += "left join [dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno  ";
            }
            else if (Brand == "BB")
            {
                sql += "left join [192.168.1.24,1833].[dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno  ";
            }

                           sql += @"where a.CLOSEFLAG = 0
                           and a.docno like '%WS%'
                           and (a.docno  like '5%')
                           ) as a
                           WHERE project = '"+ Brand + @"'
                           group by stcode,stname,project
                           order by project,stcode";

            DataSet ds = cData.getDataSetWithQueryCommand(strconn, sql, 1000, true);

            if (ds.Tables[0].Rows.Count <= 0)
            {
                cMessage.ErrorNoData();
                //return;
            }

            lsvProducts2.addDataWithDataset(ds, false, false);
        }

        private void Myinit()
        {
            lsvProducts2.LabelWrap = true;
            // Add Columns     
            lsvProducts2.Columns.Add("รหัสพนักงาน",100, HorizontalAlignment.Left);
            lsvProducts2.Columns.Add("ชื่อพนักงาน", 200, HorizontalAlignment.Left);
        }

        private void lbl_all_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i <= lsvProducts2.Items.Count - 1; i++)
            {
                lsvProducts2.Items[i].Checked = !bl;
            }

            bl = !bl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox.Text;
            lsvProducts2.Items.Clear();

            string strconn = StrConn;

            string sql = @"select stcode,stname
                           from (
                           select b.stcode,isnull(b.stname,'') as stname,a.docno,project,a.debtamount 
                           from [192.168.1.77,1434].[MONA110601].dbo.cssaleorder a ";
            if (Brand == "BC")
            {
                sql += "left join [192.168.1.220].[dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno ";
            }
            else if (Brand == "BB")
            {
                sql += "left join [dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno ";
            }
            sql += @"where a.CLOSEFLAG = 0
                           and a.docno like '%WS%'
                           and (a.docno  like '1%')
                           union all
                           select b.stcode,isnull(b.stname,'') as stname,a.docno,project,a.debtamount 
                           from [192.168.1.77,1434].[MONA110601].dbo.cssaleorder a ";
            if (Brand == "BC")
            {
                sql += "left join [dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno  ";
            }
            else if (Brand == "BB")
            {
                sql += "left join [192.168.1.24,1833].[dbbeautycommsupport].dbo.doc_st_wh b on a.DOCNO = b.docno  ";
            }

            sql += @"where a.CLOSEFLAG = 0
                           and a.docno like '%WS%'
                           and (a.docno  like '5%')
                           ) as a
                           WHERE project = '" + Brand + @"'
                           AND (stcode LIKE '%"+ key + @"%' or stname LIKE '%"+ key + @"%')
                           group by stcode,stname,project
                           order by project,stcode";

            DataSet ds = cData.getDataSetWithQueryCommand(strconn, sql, 1000, true);

            if (ds.Tables[0].Rows.Count <= 0)
            {
                cMessage.ErrorNoData();
                //return;
            }

            lsvProducts2.addDataWithDataset(ds, false, false);
        }
    }
}
