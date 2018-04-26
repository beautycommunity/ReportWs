namespace ReportWS
{
    partial class frmRPTByMonth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPTByMonth));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCondition = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.tc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCondition,
            this.toolStripButton4,
            this.tsbExport,
            this.toolStripSeparator1,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1080, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCondition
            // 
            this.tsbCondition.Image = ((System.Drawing.Image)(resources.GetObject("tsbCondition.Image")));
            this.tsbCondition.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCondition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCondition.Name = "tsbCondition";
            this.tsbCondition.Size = new System.Drawing.Size(74, 41);
            this.tsbCondition.Text = "เงื่อนไข";
            this.tsbCondition.Click += new System.EventHandler(this.tsbCondition_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbExport
            // 
            this.tsbExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCSV,
            this.tsmExcel});
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(85, 41);
            this.tsbExport.Text = "export";
            // 
            // tsmCSV
            // 
            this.tsmCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsmCSV.Image")));
            this.tsmCSV.Name = "tsmCSV";
            this.tsmCSV.Size = new System.Drawing.Size(100, 22);
            this.tsmCSV.Text = "CSV";
            this.tsmCSV.Click += new System.EventHandler(this.tsmCSV_Click);
            // 
            // tsmExcel
            // 
            this.tsmExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsmExcel.Image")));
            this.tsmExcel.Name = "tsmExcel";
            this.tsmExcel.Size = new System.Drawing.Size(100, 22);
            this.tsmExcel.Text = "Excel";
            this.tsmExcel.Click += new System.EventHandler(this.tsmExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(93, 41);
            this.tsbClose.Text = "ปิดหน้าต่าง";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabPage1);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 44);
            this.tc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1080, 562);
            this.tc.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lv);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1072, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "รายละเอียด";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(3, 2);
            this.lv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(1066, 528);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ลำดับ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ปี";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "เดือน";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "จำนวน";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ยอดขาย";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 141;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ยอด/บิล";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "จำนวนผู้ซื้อ";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 116;
            // 
            // frmRPTByMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 606);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmRPTByMonth";
            this.Text = "รายงานขายส่ง WS ตามเดือน";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCondition;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripDropDownButton tsbExport;
        private System.Windows.Forms.ToolStripMenuItem tsmCSV;
        private System.Windows.Forms.ToolStripMenuItem tsmExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}