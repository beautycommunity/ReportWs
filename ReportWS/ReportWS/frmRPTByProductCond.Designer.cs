namespace ReportWS
{
    partial class frmRPTByProductCond
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpF = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.dtpS = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndellAll = new System.Windows.Forms.Button();
            this.btndell = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(407, 296);
            this.tabControl1.TabIndex = 195;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpF);
            this.tabPage1.Controls.Add(this.dtpS);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(369, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วันที่";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ถึง วันที่";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "วันที่";
            // 
            // dtpF
            // 
            this.dtpF.DisplayThai = true;
            this.dtpF.Location = new System.Drawing.Point(111, 80);
            this.dtpF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpF.Name = "dtpF";
            this.dtpF.Size = new System.Drawing.Size(160, 24);
            this.dtpF.TabIndex = 1;
            // 
            // dtpS
            // 
            this.dtpS.DisplayThai = true;
            this.dtpS.Location = new System.Drawing.Point(111, 30);
            this.dtpS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpS.Name = "dtpS";
            this.dtpS.Size = new System.Drawing.Size(160, 24);
            this.dtpS.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lv);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(399, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สินค้า";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(3, 45);
            this.lv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(393, 219);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "รหัสสินค้า";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "สินค้า";
            this.columnHeader2.Width = 325;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndellAll);
            this.groupBox1.Controls.Add(this.btndell);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(393, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btndellAll
            // 
            this.btndellAll.Location = new System.Drawing.Point(357, 11);
            this.btndellAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndellAll.Name = "btndellAll";
            this.btndellAll.Size = new System.Drawing.Size(32, 28);
            this.btndellAll.TabIndex = 2;
            this.btndellAll.Text = "--";
            this.btndellAll.UseVisualStyleBackColor = true;
            this.btndellAll.Click += new System.EventHandler(this.btndellAll_Click);
            // 
            // btndell
            // 
            this.btndell.Location = new System.Drawing.Point(326, 11);
            this.btndell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndell.Name = "btndell";
            this.btndell.Size = new System.Drawing.Size(26, 28);
            this.btndell.TabIndex = 1;
            this.btndell.Text = "-";
            this.btndell.UseVisualStyleBackColor = true;
            this.btndell.Click += new System.EventHandler(this.btndell_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(295, 11);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(26, 28);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // frmRPTByProductCond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 335);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "frmRPTByProductCond";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private kBeautyLibrary.kbDateTimePicker dtpF;
        private kBeautyLibrary.kbDateTimePicker dtpS;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndellAll;
        private System.Windows.Forms.Button btndell;
        private System.Windows.Forms.Button btnadd;
    }
}