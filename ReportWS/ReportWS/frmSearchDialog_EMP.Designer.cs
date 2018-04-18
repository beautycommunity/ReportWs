namespace ReportWS
{
    partial class frmSearchDialog_EMP
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
            this.kbTabControl1 = new kBeautyLibrary.kbTabControl(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpEdate = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.lblEdate = new kBeautyLibrary.kbLabel(this.components);
            this.dtpSdate = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.lblSdate = new kBeautyLibrary.kbLabel(this.components);
            this.kbTabControl2 = new kBeautyLibrary.kbTabControl(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kbDateTimePicker1 = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.kbLabel1 = new kBeautyLibrary.kbLabel(this.components);
            this.kbDateTimePicker2 = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.kbLabel2 = new kBeautyLibrary.kbLabel(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_all = new System.Windows.Forms.LinkLabel();
            this.lsvProducts2 = new kBeautyLibrary.kbListView(this.components);
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kbTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kbTabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kbTabControl1
            // 
            this.kbTabControl1.Controls.Add(this.tabPage1);
            this.kbTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kbTabControl1.Location = new System.Drawing.Point(0, 39);
            this.kbTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kbTabControl1.Name = "kbTabControl1";
            this.kbTabControl1.SelectedIndex = 0;
            this.kbTabControl1.Size = new System.Drawing.Size(431, 323);
            this.kbTabControl1.TabIndex = 195;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpEdate);
            this.tabPage1.Controls.Add(this.lblEdate);
            this.tabPage1.Controls.Add(this.dtpSdate);
            this.tabPage1.Controls.Add(this.lblSdate);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(423, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วันที่";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpEdate
            // 
            this.dtpEdate.DisplayThai = true;
            this.dtpEdate.Location = new System.Drawing.Point(145, 106);
            this.dtpEdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEdate.Name = "dtpEdate";
            this.dtpEdate.Size = new System.Drawing.Size(178, 24);
            this.dtpEdate.TabIndex = 3;
            // 
            // lblEdate
            // 
            this.lblEdate.AutoSize = true;
            this.lblEdate.Location = new System.Drawing.Point(76, 112);
            this.lblEdate.Name = "lblEdate";
            this.lblEdate.Size = new System.Drawing.Size(49, 17);
            this.lblEdate.TabIndex = 2;
            this.lblEdate.Text = "ถึงวันที่";
            // 
            // dtpSdate
            // 
            this.dtpSdate.DisplayThai = true;
            this.dtpSdate.Location = new System.Drawing.Point(145, 62);
            this.dtpSdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSdate.Name = "dtpSdate";
            this.dtpSdate.Size = new System.Drawing.Size(178, 24);
            this.dtpSdate.TabIndex = 1;
            // 
            // lblSdate
            // 
            this.lblSdate.AutoSize = true;
            this.lblSdate.Location = new System.Drawing.Point(68, 68);
            this.lblSdate.Name = "lblSdate";
            this.lblSdate.Size = new System.Drawing.Size(57, 17);
            this.lblSdate.TabIndex = 0;
            this.lblSdate.Text = "จากวันที่";
            // 
            // kbTabControl2
            // 
            this.kbTabControl2.Controls.Add(this.tabPage2);
            this.kbTabControl2.Controls.Add(this.tabPage3);
            this.kbTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kbTabControl2.Location = new System.Drawing.Point(0, 39);
            this.kbTabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kbTabControl2.Name = "kbTabControl2";
            this.kbTabControl2.SelectedIndex = 0;
            this.kbTabControl2.Size = new System.Drawing.Size(431, 323);
            this.kbTabControl2.TabIndex = 196;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kbDateTimePicker1);
            this.tabPage2.Controls.Add(this.kbLabel1);
            this.tabPage2.Controls.Add(this.kbDateTimePicker2);
            this.tabPage2.Controls.Add(this.kbLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(423, 293);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "วันที่";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kbDateTimePicker1
            // 
            this.kbDateTimePicker1.DisplayThai = true;
            this.kbDateTimePicker1.Location = new System.Drawing.Point(145, 106);
            this.kbDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kbDateTimePicker1.Name = "kbDateTimePicker1";
            this.kbDateTimePicker1.Size = new System.Drawing.Size(178, 24);
            this.kbDateTimePicker1.TabIndex = 3;
            // 
            // kbLabel1
            // 
            this.kbLabel1.AutoSize = true;
            this.kbLabel1.Location = new System.Drawing.Point(76, 112);
            this.kbLabel1.Name = "kbLabel1";
            this.kbLabel1.Size = new System.Drawing.Size(49, 17);
            this.kbLabel1.TabIndex = 2;
            this.kbLabel1.Text = "ถึงวันที่";
            // 
            // kbDateTimePicker2
            // 
            this.kbDateTimePicker2.DisplayThai = true;
            this.kbDateTimePicker2.Location = new System.Drawing.Point(145, 62);
            this.kbDateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kbDateTimePicker2.Name = "kbDateTimePicker2";
            this.kbDateTimePicker2.Size = new System.Drawing.Size(178, 24);
            this.kbDateTimePicker2.TabIndex = 1;
            // 
            // kbLabel2
            // 
            this.kbLabel2.AutoSize = true;
            this.kbLabel2.Location = new System.Drawing.Point(68, 68);
            this.kbLabel2.Name = "kbLabel2";
            this.kbLabel2.Size = new System.Drawing.Size(57, 17);
            this.kbLabel2.TabIndex = 0;
            this.kbLabel2.Text = "จากวันที่";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBox);
            this.tabPage3.Controls.Add(this.lbl_all);
            this.tabPage3.Controls.Add(this.lsvProducts2);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(423, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "พนักงานงาน";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_all
            // 
            this.lbl_all.AutoSize = true;
            this.lbl_all.Location = new System.Drawing.Point(291, 12);
            this.lbl_all.Name = "lbl_all";
            this.lbl_all.Size = new System.Drawing.Size(124, 17);
            this.lbl_all.TabIndex = 5;
            this.lbl_all.TabStop = true;
            this.lbl_all.Text = "เลือกทั้งหมด/ยกเลิก";
            this.lbl_all.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_all_LinkClicked);
            // 
            // lsvProducts2
            // 
            this.lsvProducts2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvProducts2.CheckBoxes = true;
            this.lsvProducts2.FullRowSelect = true;
            this.lsvProducts2.GridLines = true;
            this.lsvProducts2.Location = new System.Drawing.Point(7, 40);
            this.lsvProducts2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvProducts2.Name = "lsvProducts2";
            this.lsvProducts2.Row = null;
            this.lsvProducts2.Size = new System.Drawing.Size(411, 251);
            this.lsvProducts2.TabIndex = 4;
            this.lsvProducts2.UseCompatibleStateImageBehavior = false;
            this.lsvProducts2.View = System.Windows.Forms.View.Details;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(7, 11);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(159, 24);
            this.textBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "ค้นหา";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchDialog_EMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 362);
            this.Controls.Add(this.kbTabControl2);
            this.Controls.Add(this.kbTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmSearchDialog_EMP";
            this.Load += new System.EventHandler(this.frmSearchDialog_EMP_Load);
            this.Controls.SetChildIndex(this.kbTabControl1, 0);
            this.Controls.SetChildIndex(this.kbTabControl2, 0);
            this.kbTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.kbTabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kBeautyLibrary.kbTabControl kbTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private kBeautyLibrary.kbDateTimePicker dtpEdate;
        private kBeautyLibrary.kbLabel lblEdate;
        private kBeautyLibrary.kbDateTimePicker dtpSdate;
        private kBeautyLibrary.kbLabel lblSdate;
        private kBeautyLibrary.kbTabControl kbTabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private kBeautyLibrary.kbDateTimePicker kbDateTimePicker1;
        private kBeautyLibrary.kbLabel kbLabel1;
        private kBeautyLibrary.kbDateTimePicker kbDateTimePicker2;
        private kBeautyLibrary.kbLabel kbLabel2;
        private System.Windows.Forms.TabPage tabPage3;
        private kBeautyLibrary.kbListView lsvProducts2;
        private System.Windows.Forms.LinkLabel lbl_all;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
    }
}