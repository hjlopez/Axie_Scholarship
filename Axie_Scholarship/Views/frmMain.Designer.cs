﻿namespace Axie_Scholarship
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddScholar = new System.Windows.Forms.Button();
            this.btnViewScholar = new System.Windows.Forms.Button();
            this.btnRemoveScholar = new System.Windows.Forms.Button();
            this.dgvScholarList = new System.Windows.Forms.DataGridView();
            this.ScholarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCutOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAccomp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddScholar
            // 
            this.btnAddScholar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddScholar.Location = new System.Drawing.Point(64, 60);
            this.btnAddScholar.Name = "btnAddScholar";
            this.btnAddScholar.Size = new System.Drawing.Size(128, 46);
            this.btnAddScholar.TabIndex = 0;
            this.btnAddScholar.Text = "Add Scholar";
            this.btnAddScholar.UseVisualStyleBackColor = true;
            this.btnAddScholar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewScholar
            // 
            this.btnViewScholar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewScholar.Location = new System.Drawing.Point(349, 60);
            this.btnViewScholar.Name = "btnViewScholar";
            this.btnViewScholar.Size = new System.Drawing.Size(128, 46);
            this.btnViewScholar.TabIndex = 1;
            this.btnViewScholar.Text = "View Scholar";
            this.btnViewScholar.UseVisualStyleBackColor = true;
            this.btnViewScholar.Click += new System.EventHandler(this.btnViewScholar_Click);
            // 
            // btnRemoveScholar
            // 
            this.btnRemoveScholar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveScholar.Location = new System.Drawing.Point(649, 60);
            this.btnRemoveScholar.Name = "btnRemoveScholar";
            this.btnRemoveScholar.Size = new System.Drawing.Size(128, 46);
            this.btnRemoveScholar.TabIndex = 2;
            this.btnRemoveScholar.Text = "Remove Scholar";
            this.btnRemoveScholar.UseVisualStyleBackColor = true;
            // 
            // dgvScholarList
            // 
            this.dgvScholarList.AllowUserToAddRows = false;
            this.dgvScholarList.AllowUserToDeleteRows = false;
            this.dgvScholarList.AllowUserToResizeColumns = false;
            this.dgvScholarList.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScholarList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvScholarList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScholarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvScholarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScholarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScholarId,
            this.colName,
            this.colBegin,
            this.colCutOff,
            this.colShare,
            this.colActive});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScholarList.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvScholarList.Location = new System.Drawing.Point(111, 131);
            this.dgvScholarList.MultiSelect = false;
            this.dgvScholarList.Name = "dgvScholarList";
            this.dgvScholarList.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScholarList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvScholarList.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScholarList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvScholarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScholarList.Size = new System.Drawing.Size(623, 248);
            this.dgvScholarList.TabIndex = 3;
            // 
            // ScholarId
            // 
            this.ScholarId.DataPropertyName = "ScholarId";
            this.ScholarId.HeaderText = "Scholar ID";
            this.ScholarId.Name = "ScholarId";
            this.ScholarId.ReadOnly = true;
            this.ScholarId.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "ScholarName";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colBegin
            // 
            this.colBegin.DataPropertyName = "DateStarted";
            this.colBegin.HeaderText = "Scholar Begin Date";
            this.colBegin.Name = "colBegin";
            this.colBegin.ReadOnly = true;
            // 
            // colCutOff
            // 
            this.colCutOff.DataPropertyName = "CutOff";
            this.colCutOff.HeaderText = "Cut Off Days";
            this.colCutOff.Name = "colCutOff";
            this.colCutOff.ReadOnly = true;
            // 
            // colShare
            // 
            this.colShare.DataPropertyName = "ScholarCut";
            this.colShare.HeaderText = "Share %";
            this.colShare.Name = "colShare";
            this.colShare.ReadOnly = true;
            // 
            // colActive
            // 
            this.colActive.DataPropertyName = "IsActive";
            this.colActive.HeaderText = "Is Active?";
            this.colActive.Name = "colActive";
            this.colActive.ReadOnly = true;
            // 
            // btnAccomp
            // 
            this.btnAccomp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccomp.Location = new System.Drawing.Point(358, 392);
            this.btnAccomp.Name = "btnAccomp";
            this.btnAccomp.Size = new System.Drawing.Size(128, 46);
            this.btnAccomp.TabIndex = 4;
            this.btnAccomp.Text = "Accomplishments";
            this.btnAccomp.UseVisualStyleBackColor = true;
            this.btnAccomp.Click += new System.EventHandler(this.btnAccomp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.btnAccomp);
            this.Controls.Add(this.dgvScholarList);
            this.Controls.Add(this.btnRemoveScholar);
            this.Controls.Add(this.btnViewScholar);
            this.Controls.Add(this.btnAddScholar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Axie Scholarship Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddScholar;
        private System.Windows.Forms.Button btnViewScholar;
        private System.Windows.Forms.Button btnRemoveScholar;
        public System.Windows.Forms.DataGridView dgvScholarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScholarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCutOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShare;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
        private System.Windows.Forms.Button btnAccomp;
    }
}

