namespace Axie_Scholarship.Views
{
    partial class frmScholarView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblScholarName = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCutOff = new System.Windows.Forms.TextBox();
            this.dgvScholarDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScholarCut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbNotCashOut = new System.Windows.Forms.RadioButton();
            this.rbCashOut = new System.Windows.Forms.RadioButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScholarName
            // 
            this.lblScholarName.AutoSize = true;
            this.lblScholarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScholarName.Location = new System.Drawing.Point(22, 21);
            this.lblScholarName.Name = "lblScholarName";
            this.lblScholarName.Size = new System.Drawing.Size(236, 24);
            this.lblScholarName.TabIndex = 0;
            this.lblScholarName.Text = "SCHOLAR NAME HERE";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(1014, 28);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(73, 17);
            this.chkActive.TabIndex = 1;
            this.chkActive.Text = "Is Active?";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1086, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CUT OFF DAYS";
            // 
            // txtCutOff
            // 
            this.txtCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCutOff.Location = new System.Drawing.Point(68, 120);
            this.txtCutOff.Name = "txtCutOff";
            this.txtCutOff.Size = new System.Drawing.Size(100, 62);
            this.txtCutOff.TabIndex = 5;
            this.txtCutOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCutOff.TextChanged += new System.EventHandler(this.txtCutOff_TextChanged);
            // 
            // dgvScholarDetails
            // 
            this.dgvScholarDetails.AllowUserToAddRows = false;
            this.dgvScholarDetails.AllowUserToDeleteRows = false;
            this.dgvScholarDetails.AllowUserToResizeColumns = false;
            this.dgvScholarDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScholarDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvScholarDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScholarDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvScholarDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScholarDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvScholarDetails.Location = new System.Drawing.Point(267, 79);
            this.dgvScholarDetails.Name = "dgvScholarDetails";
            this.dgvScholarDetails.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScholarDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvScholarDetails.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScholarDetails.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvScholarDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScholarDetails.Size = new System.Drawing.Size(740, 420);
            this.dgvScholarDetails.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "SHARE";
            // 
            // txtScholarCut
            // 
            this.txtScholarCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScholarCut.Location = new System.Drawing.Point(68, 257);
            this.txtScholarCut.Name = "txtScholarCut";
            this.txtScholarCut.Size = new System.Drawing.Size(100, 62);
            this.txtScholarCut.TabIndex = 8;
            this.txtScholarCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScholarCut.TextChanged += new System.EventHandler(this.txtScholarCut_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "%";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(1044, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 57);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add SLP Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEntry.Location = new System.Drawing.Point(1044, 157);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(101, 57);
            this.btnDeleteEntry.TabIndex = 11;
            this.btnDeleteEntry.Text = "Delete SLP Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbNotCashOut);
            this.groupBox1.Controls.Add(this.rbCashOut);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Location = new System.Drawing.Point(1025, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 266);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Location = new System.Drawing.Point(28, 226);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(22, 191);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 6;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbNotCashOut
            // 
            this.rbNotCashOut.AutoSize = true;
            this.rbNotCashOut.Location = new System.Drawing.Point(22, 158);
            this.rbNotCashOut.Name = "rbNotCashOut";
            this.rbNotCashOut.Size = new System.Drawing.Size(101, 17);
            this.rbNotCashOut.TabIndex = 5;
            this.rbNotCashOut.TabStop = true;
            this.rbNotCashOut.Text = "Not Cashed Out";
            this.rbNotCashOut.UseVisualStyleBackColor = true;
            this.rbNotCashOut.CheckedChanged += new System.EventHandler(this.rbNotCashOut_CheckedChanged);
            // 
            // rbCashOut
            // 
            this.rbCashOut.AutoSize = true;
            this.rbCashOut.Location = new System.Drawing.Point(22, 125);
            this.rbCashOut.Name = "rbCashOut";
            this.rbCashOut.Size = new System.Drawing.Size(81, 17);
            this.rbCashOut.TabIndex = 4;
            this.rbCashOut.TabStop = true;
            this.rbCashOut.Text = "Cashed Out";
            this.rbCashOut.UseVisualStyleBackColor = true;
            this.rbCashOut.CheckedChanged += new System.EventHandler(this.rbCashOut_CheckedChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(22, 92);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(92, 20);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(19, 40);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(92, 20);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // btnCashOut
            // 
            this.btnCashOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashOut.Location = new System.Drawing.Point(42, 19);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(114, 57);
            this.btnCashOut.TabIndex = 13;
            this.btnCashOut.Text = "Cash Out Selected";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.btnCashOut);
            this.groupBox2.Location = new System.Drawing.Point(26, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 158);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cash Out";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(42, 84);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(114, 57);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate Excel for Selected";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExtras
            // 
            this.btnExtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtras.Location = new System.Drawing.Point(921, 50);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(75, 23);
            this.btnExtras.TabIndex = 15;
            this.btnExtras.Text = "Extras";
            this.btnExtras.UseVisualStyleBackColor = true;
            this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(267, 54);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(187, 17);
            this.chkSelectAll.TabIndex = 16;
            this.chkSelectAll.Text = "Select All Non-Cashed Out Entries";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // frmScholarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 528);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.btnExtras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScholarCut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvScholarDetails);
            this.Controls.Add(this.txtCutOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblScholarName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmScholarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scholar Details";
            this.Load += new System.EventHandler(this.frmScholarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScholarName;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCutOff;
        public System.Windows.Forms.DataGridView dgvScholarDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScholarCut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbNotCashOut;
        private System.Windows.Forms.RadioButton rbCashOut;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.CheckBox chkSelectAll;
    }
}