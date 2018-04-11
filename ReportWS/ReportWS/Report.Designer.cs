namespace ReportWS
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานรายปToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานตามลกคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOffline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานตามพนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1017, 26);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายงานรายปToolStripMenuItem,
            this.รายงานตามพนกงานToolStripMenuItem,
            this.รายงานตามลกคาToolStripMenuItem,
            this.mnuOffline,
            this.toolStripMenuItem3,
            this.mnuExit});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(78, 20);
            this.menu.Text = "ReportWS";
            // 
            // รายงานรายปToolStripMenuItem
            // 
            this.รายงานรายปToolStripMenuItem.Name = "รายงานรายปToolStripMenuItem";
            this.รายงานรายปToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.รายงานรายปToolStripMenuItem.Text = "รายงานรายปี";
            this.รายงานรายปToolStripMenuItem.Click += new System.EventHandler(this.รายงานรายปToolStripMenuItem_Click);
            // 
            // รายงานตามลกคาToolStripMenuItem
            // 
            this.รายงานตามลกคาToolStripMenuItem.Name = "รายงานตามลกคาToolStripMenuItem";
            this.รายงานตามลกคาToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.รายงานตามลกคาToolStripMenuItem.Text = "รายงานตามลูกค้า";
            this.รายงานตามลกคาToolStripMenuItem.Click += new System.EventHandler(this.รายงานตามลกคาToolStripMenuItem_Click);
            // 
            // mnuOffline
            // 
            this.mnuOffline.CheckOnClick = true;
            this.mnuOffline.Name = "mnuOffline";
            this.mnuOffline.Size = new System.Drawing.Size(183, 22);
            this.mnuOffline.Text = "รายงานแบบละเอียด";
            this.mnuOffline.Click += new System.EventHandler(this.mnuOffline_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(183, 22);
            this.mnuExit.Text = "Exit";
            // 
            // รายงานตามพนกงานToolStripMenuItem
            // 
            this.รายงานตามพนกงานToolStripMenuItem.Name = "รายงานตามพนกงานToolStripMenuItem";
            this.รายงานตามพนกงานToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.รายงานตามพนกงานToolStripMenuItem.Text = "รายงานตามพนักงาน";
            this.รายงานตามพนกงานToolStripMenuItem.Click += new System.EventHandler(this.รายงานตามพนกงานToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 616);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem mnuOffline;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem รายงานรายปToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายงานตามลกคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายงานตามพนกงานToolStripMenuItem;
    }
}

