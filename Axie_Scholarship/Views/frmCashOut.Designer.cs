namespace Axie_Scholarship.Views
{
    partial class frmCashOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMissingDates = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalSLP = new System.Windows.Forms.Label();
            this.grpScholar = new System.Windows.Forms.GroupBox();
            this.lblAdjSLP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShare = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScholarSLP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkExcel = new System.Windows.Forms.CheckBox();
            this.chkApply = new System.Windows.Forms.CheckBox();
            this.lblSLPValue = new System.Windows.Forms.Label();
            this.lblConvert = new System.Windows.Forms.Label();
            this.btnSLPLatest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissingDates)).BeginInit();
            this.grpScholar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inclusive Dates:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(210, 20);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(110, 24);
            this.lblDateFrom.TabIndex = 1;
            this.lblDateFrom.Text = "1 Jan 2022";
            this.lblDateFrom.Click += new System.EventHandler(this.lblDateFrom_Click);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(441, 20);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(125, 24);
            this.lblDateTo.TabIndex = 1;
            this.lblDateTo.Text = "31 Dec 2022";
            this.lblDateTo.Click += new System.EventHandler(this.lblDateTo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "to";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvMissingDates
            // 
            this.dgvMissingDates.AllowUserToAddRows = false;
            this.dgvMissingDates.AllowUserToDeleteRows = false;
            this.dgvMissingDates.AllowUserToResizeColumns = false;
            this.dgvMissingDates.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMissingDates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMissingDates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMissingDates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMissingDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissingDates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMissingDates.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMissingDates.Location = new System.Drawing.Point(22, 73);
            this.dgvMissingDates.Name = "dgvMissingDates";
            this.dgvMissingDates.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMissingDates.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMissingDates.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMissingDates.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMissingDates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMissingDates.Size = new System.Drawing.Size(152, 94);
            this.dgvMissingDates.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Missing Dates";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total SLP:";
            // 
            // lblTotalSLP
            // 
            this.lblTotalSLP.AutoSize = true;
            this.lblTotalSLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSLP.Location = new System.Drawing.Point(142, 25);
            this.lblTotalSLP.Name = "lblTotalSLP";
            this.lblTotalSLP.Size = new System.Drawing.Size(40, 24);
            this.lblTotalSLP.TabIndex = 9;
            this.lblTotalSLP.Text = "500";
            // 
            // grpScholar
            // 
            this.grpScholar.Controls.Add(this.lblAdjSLP);
            this.grpScholar.Controls.Add(this.label6);
            this.grpScholar.Controls.Add(this.lblShare);
            this.grpScholar.Controls.Add(this.label5);
            this.grpScholar.Controls.Add(this.lblScholarSLP);
            this.grpScholar.Controls.Add(this.label3);
            this.grpScholar.Controls.Add(this.lblTotalSLP);
            this.grpScholar.Controls.Add(this.label4);
            this.grpScholar.Location = new System.Drawing.Point(214, 73);
            this.grpScholar.Name = "grpScholar";
            this.grpScholar.Size = new System.Drawing.Size(363, 94);
            this.grpScholar.TabIndex = 10;
            this.grpScholar.TabStop = false;
            this.grpScholar.Text = "Scholar Details";
            // 
            // lblAdjSLP
            // 
            this.lblAdjSLP.AutoSize = true;
            this.lblAdjSLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjSLP.Location = new System.Drawing.Point(285, 25);
            this.lblAdjSLP.Name = "lblAdjSLP";
            this.lblAdjSLP.Size = new System.Drawing.Size(36, 24);
            this.lblAdjSLP.TabIndex = 15;
            this.lblAdjSLP.Text = "-20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adj.";
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShare.Location = new System.Drawing.Point(285, 60);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(45, 24);
            this.lblShare.TabIndex = 13;
            this.lblShare.Text = "50%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Share:";
            // 
            // lblScholarSLP
            // 
            this.lblScholarSLP.AutoSize = true;
            this.lblScholarSLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScholarSLP.Location = new System.Drawing.Point(142, 60);
            this.lblScholarSLP.Name = "lblScholarSLP";
            this.lblScholarSLP.Size = new System.Drawing.Size(40, 24);
            this.lblScholarSLP.TabIndex = 11;
            this.lblScholarSLP.Text = "250";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Scholar SLP:";
            // 
            // btnCashOut
            // 
            this.btnCashOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashOut.Location = new System.Drawing.Point(634, 94);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(122, 36);
            this.btnCashOut.TabIndex = 11;
            this.btnCashOut.Text = "Confirm Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(634, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkExcel
            // 
            this.chkExcel.AutoSize = true;
            this.chkExcel.Checked = true;
            this.chkExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcel.Location = new System.Drawing.Point(22, 203);
            this.chkExcel.Name = "chkExcel";
            this.chkExcel.Size = new System.Drawing.Size(180, 17);
            this.chkExcel.TabIndex = 13;
            this.chkExcel.Text = "Generate Excel File on Cash Out";
            this.chkExcel.UseVisualStyleBackColor = true;
            // 
            // chkApply
            // 
            this.chkApply.AutoSize = true;
            this.chkApply.Location = new System.Drawing.Point(445, 60);
            this.chkApply.Name = "chkApply";
            this.chkApply.Size = new System.Drawing.Size(130, 17);
            this.chkApply.TabIndex = 14;
            this.chkApply.Text = "Apply SLP Adjustment";
            this.chkApply.UseVisualStyleBackColor = true;
            this.chkApply.CheckedChanged += new System.EventHandler(this.chkApply_CheckedChanged);
            // 
            // lblSLPValue
            // 
            this.lblSLPValue.AutoSize = true;
            this.lblSLPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLPValue.Location = new System.Drawing.Point(592, 172);
            this.lblSLPValue.Name = "lblSLPValue";
            this.lblSLPValue.Size = new System.Drawing.Size(182, 24);
            this.lblSLPValue.TabIndex = 16;
            this.lblSLPValue.Text = "SLP Value: Php 0.00";
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvert.ForeColor = System.Drawing.Color.Green;
            this.lblConvert.Location = new System.Drawing.Point(259, 190);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(276, 24);
            this.lblConvert.TabIndex = 17;
            this.lblConvert.Text = "Scholar Receives: Php 1,250.25";
            // 
            // btnSLPLatest
            // 
            this.btnSLPLatest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSLPLatest.Location = new System.Drawing.Point(634, 199);
            this.btnSLPLatest.Name = "btnSLPLatest";
            this.btnSLPLatest.Size = new System.Drawing.Size(105, 27);
            this.btnSLPLatest.TabIndex = 18;
            this.btnSLPLatest.Text = "Check SLP Value";
            this.btnSLPLatest.UseVisualStyleBackColor = true;
            this.btnSLPLatest.Click += new System.EventHandler(this.btnSLPLatest_Click);
            // 
            // frmCashOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.btnSLPLatest);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.lblSLPValue);
            this.Controls.Add(this.chkApply);
            this.Controls.Add(this.chkExcel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.grpScholar);
            this.Controls.Add(this.dgvMissingDates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCashOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Out";
            this.Load += new System.EventHandler(this.frmCashOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissingDates)).EndInit();
            this.grpScholar.ResumeLayout(false);
            this.grpScholar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvMissingDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalSLP;
        private System.Windows.Forms.GroupBox grpScholar;
        private System.Windows.Forms.Label lblScholarSLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkExcel;
        private System.Windows.Forms.Label lblAdjSLP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkApply;
        private System.Windows.Forms.Label lblSLPValue;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.Button btnSLPLatest;
    }
}