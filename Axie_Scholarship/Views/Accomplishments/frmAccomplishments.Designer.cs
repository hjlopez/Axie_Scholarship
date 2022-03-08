namespace Axie_Scholarship.Views
{
    partial class frmAccomplishments
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
            this.tbView = new System.Windows.Forms.TabControl();
            this.tbBonus = new System.Windows.Forms.TabPage();
            this.tbDeduct = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddPenalty = new System.Windows.Forms.Button();
            this.btnEditPenalty = new System.Windows.Forms.Button();
            this.btnDeletePenalty = new System.Windows.Forms.Button();
            this.dgvBonus = new System.Windows.Forms.DataGridView();
            this.colIDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescriptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRewardB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeductions = new System.Windows.Forms.DataGridView();
            this.colIDDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescriptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRewardD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbView.SuspendLayout();
            this.tbBonus.SuspendLayout();
            this.tbDeduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeductions)).BeginInit();
            this.SuspendLayout();
            // 
            // tbView
            // 
            this.tbView.Controls.Add(this.tbBonus);
            this.tbView.Controls.Add(this.tbDeduct);
            this.tbView.Location = new System.Drawing.Point(31, 12);
            this.tbView.Name = "tbView";
            this.tbView.SelectedIndex = 0;
            this.tbView.Size = new System.Drawing.Size(758, 426);
            this.tbView.TabIndex = 0;
            // 
            // tbBonus
            // 
            this.tbBonus.Controls.Add(this.dgvBonus);
            this.tbBonus.Location = new System.Drawing.Point(4, 22);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Padding = new System.Windows.Forms.Padding(3);
            this.tbBonus.Size = new System.Drawing.Size(750, 400);
            this.tbBonus.TabIndex = 0;
            this.tbBonus.Text = "Bonuses";
            this.tbBonus.UseVisualStyleBackColor = true;
            // 
            // tbDeduct
            // 
            this.tbDeduct.Controls.Add(this.dgvDeductions);
            this.tbDeduct.Location = new System.Drawing.Point(4, 22);
            this.tbDeduct.Name = "tbDeduct";
            this.tbDeduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbDeduct.Size = new System.Drawing.Size(750, 400);
            this.tbDeduct.TabIndex = 1;
            this.tbDeduct.Text = "Deductions";
            this.tbDeduct.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(795, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 67);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Accomplishment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(795, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 67);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Accomplishment";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(795, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 67);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Accomplishment";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddPenalty
            // 
            this.btnAddPenalty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPenalty.Location = new System.Drawing.Point(974, 56);
            this.btnAddPenalty.Name = "btnAddPenalty";
            this.btnAddPenalty.Size = new System.Drawing.Size(146, 67);
            this.btnAddPenalty.TabIndex = 4;
            this.btnAddPenalty.Text = "Add Penalties";
            this.btnAddPenalty.UseVisualStyleBackColor = true;
            // 
            // btnEditPenalty
            // 
            this.btnEditPenalty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPenalty.Location = new System.Drawing.Point(974, 191);
            this.btnEditPenalty.Name = "btnEditPenalty";
            this.btnEditPenalty.Size = new System.Drawing.Size(146, 67);
            this.btnEditPenalty.TabIndex = 5;
            this.btnEditPenalty.Text = "Edit Penalties";
            this.btnEditPenalty.UseVisualStyleBackColor = true;
            // 
            // btnDeletePenalty
            // 
            this.btnDeletePenalty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePenalty.Location = new System.Drawing.Point(974, 332);
            this.btnDeletePenalty.Name = "btnDeletePenalty";
            this.btnDeletePenalty.Size = new System.Drawing.Size(146, 67);
            this.btnDeletePenalty.TabIndex = 6;
            this.btnDeletePenalty.Text = "Delete Penalties";
            this.btnDeletePenalty.UseVisualStyleBackColor = true;
            // 
            // dgvBonus
            // 
            this.dgvBonus.AllowUserToAddRows = false;
            this.dgvBonus.AllowUserToDeleteRows = false;
            this.dgvBonus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBonus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBonus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBonus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBonus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDB,
            this.colNameB,
            this.colDescriptionB,
            this.colRewardB});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBonus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBonus.Location = new System.Drawing.Point(3, 6);
            this.dgvBonus.MultiSelect = false;
            this.dgvBonus.Name = "dgvBonus";
            this.dgvBonus.ReadOnly = true;
            this.dgvBonus.RowHeadersVisible = false;
            this.dgvBonus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBonus.Size = new System.Drawing.Size(744, 388);
            this.dgvBonus.TabIndex = 0;
            // 
            // colIDB
            // 
            this.colIDB.HeaderText = "Id";
            this.colIDB.Name = "colIDB";
            this.colIDB.ReadOnly = true;
            this.colIDB.Visible = false;
            // 
            // colNameB
            // 
            this.colNameB.HeaderText = "Name";
            this.colNameB.Name = "colNameB";
            this.colNameB.ReadOnly = true;
            // 
            // colDescriptionB
            // 
            this.colDescriptionB.HeaderText = "Description";
            this.colDescriptionB.Name = "colDescriptionB";
            this.colDescriptionB.ReadOnly = true;
            // 
            // colRewardB
            // 
            this.colRewardB.HeaderText = "Reward";
            this.colRewardB.Name = "colRewardB";
            this.colRewardB.ReadOnly = true;
            // 
            // dgvDeductions
            // 
            this.dgvDeductions.AllowUserToAddRows = false;
            this.dgvDeductions.AllowUserToDeleteRows = false;
            this.dgvDeductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeductions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeductions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeductions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDDeduction,
            this.colNameD,
            this.colDescriptionD,
            this.colRewardD});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeductions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeductions.Location = new System.Drawing.Point(5, 6);
            this.dgvDeductions.MultiSelect = false;
            this.dgvDeductions.Name = "dgvDeductions";
            this.dgvDeductions.ReadOnly = true;
            this.dgvDeductions.RowHeadersVisible = false;
            this.dgvDeductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeductions.Size = new System.Drawing.Size(744, 388);
            this.dgvDeductions.TabIndex = 1;
            // 
            // colIDDeduction
            // 
            this.colIDDeduction.HeaderText = "Id";
            this.colIDDeduction.Name = "colIDDeduction";
            this.colIDDeduction.ReadOnly = true;
            this.colIDDeduction.Visible = false;
            // 
            // colNameD
            // 
            this.colNameD.HeaderText = "Name";
            this.colNameD.Name = "colNameD";
            this.colNameD.ReadOnly = true;
            // 
            // colDescriptionD
            // 
            this.colDescriptionD.HeaderText = "Description";
            this.colDescriptionD.Name = "colDescriptionD";
            this.colDescriptionD.ReadOnly = true;
            // 
            // colRewardD
            // 
            this.colRewardD.HeaderText = "Reward";
            this.colRewardD.Name = "colRewardD";
            this.colRewardD.ReadOnly = true;
            // 
            // frmAccomplishments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.btnDeletePenalty);
            this.Controls.Add(this.btnEditPenalty);
            this.Controls.Add(this.btnAddPenalty);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccomplishments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tbView.ResumeLayout(false);
            this.tbBonus.ResumeLayout(false);
            this.tbDeduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeductions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbView;
        private System.Windows.Forms.TabPage tbBonus;
        private System.Windows.Forms.TabPage tbDeduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddPenalty;
        private System.Windows.Forms.Button btnEditPenalty;
        private System.Windows.Forms.Button btnDeletePenalty;
        private System.Windows.Forms.DataGridView dgvBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescriptionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRewardB;
        private System.Windows.Forms.DataGridView dgvDeductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescriptionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRewardD;
    }
}