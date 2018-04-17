namespace ReportWS
{
    partial class frmSearchDialog
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
            this.kbTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // frmSearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 362);
            this.Controls.Add(this.kbTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmSearchDialog";
            this.Controls.SetChildIndex(this.kbTabControl1, 0);
            this.kbTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}