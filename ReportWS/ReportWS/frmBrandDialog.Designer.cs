namespace ReportWS
{
    partial class frmBrandDialog
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
            this.lblSdate = new kBeautyLibrary.kbLabel(this.components);
            this.comboBox = new System.Windows.Forms.ComboBox();
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
            this.kbTabControl1.Size = new System.Drawing.Size(441, 299);
            this.kbTabControl1.TabIndex = 196;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox);
            this.tabPage1.Controls.Add(this.lblSdate);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(433, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วันที่";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSdate
            // 
            this.lblSdate.AutoSize = true;
            this.lblSdate.Location = new System.Drawing.Point(60, 68);
            this.lblSdate.Name = "lblSdate";
            this.lblSdate.Size = new System.Drawing.Size(79, 17);
            this.lblSdate.TabIndex = 0;
            this.lblSdate.Text = "เลือกแบรนด์";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(158, 65);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 25);
            this.comboBox.TabIndex = 1;
            this.comboBox.Text = "-- เลือกแบนด์ --";
            // 
            // frmBrandDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 338);
            this.Controls.Add(this.kbTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmBrandDialog";
            this.Text = "frmBrandDialog";
            this.Load += new System.EventHandler(this.frmBrandDialog_Load);
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
        private kBeautyLibrary.kbLabel lblSdate;
        private System.Windows.Forms.ComboBox comboBox;
    }
}