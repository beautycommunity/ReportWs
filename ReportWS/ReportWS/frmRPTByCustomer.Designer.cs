namespace ReportWS
{
    partial class frmRPTByCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPTByCustomer));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportError = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.lsvSearch = new kBeautyLibrary.kbListView(this.components);
            this.csvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.mnuExportError,
            this.toolStripSeparator1,
            this.btnClose});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(909, 39);
            this.toolStrip2.TabIndex = 210;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 36);
            this.toolStripButton1.Text = "เงื่อนไข";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // mnuExportError
            // 
            this.mnuExportError.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportExcel,
            this.csvToolStripMenuItem});
            this.mnuExportError.Image = ((System.Drawing.Image)(resources.GetObject("mnuExportError.Image")));
            this.mnuExportError.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuExportError.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuExportError.Name = "mnuExportError";
            this.mnuExportError.Size = new System.Drawing.Size(114, 36);
            this.mnuExportError.Text = "ส่งออกข้อมูล";
            // 
            // mnuExportExcel
            // 
            this.mnuExportExcel.Name = "mnuExportExcel";
            this.mnuExportExcel.Size = new System.Drawing.Size(152, 22);
            this.mnuExportExcel.Text = "Excel";
            this.mnuExportExcel.Click += new System.EventHandler(this.mnuExportExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 36);
            this.btnClose.Text = "ปิดหน้าต่าง";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lsvSearch
            // 
            this.lsvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvSearch.FullRowSelect = true;
            this.lsvSearch.GridLines = true;
            this.lsvSearch.Location = new System.Drawing.Point(13, 42);
            this.lsvSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsvSearch.Name = "lsvSearch";
            this.lsvSearch.Row = null;
            this.lsvSearch.Size = new System.Drawing.Size(883, 439);
            this.lsvSearch.TabIndex = 213;
            this.lsvSearch.UseCompatibleStateImageBehavior = false;
            this.lsvSearch.View = System.Windows.Forms.View.Details;
            // 
            // csvToolStripMenuItem
            // 
            this.csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            this.csvToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.csvToolStripMenuItem.Text = "csv";
            this.csvToolStripMenuItem.Click += new System.EventHandler(this.csvToolStripMenuItem_Click);
            // 
            // frmRPTByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 493);
            this.Controls.Add(this.lsvSearch);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmRPTByCustomer";
            this.Text = "รายงานตามลูกค้า";
            this.Load += new System.EventHandler(this.WSEmployee_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton mnuExportError;
        private System.Windows.Forms.ToolStripMenuItem mnuExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private kBeautyLibrary.kbListView lsvSearch;
        private System.Windows.Forms.ToolStripMenuItem csvToolStripMenuItem;
    }
}