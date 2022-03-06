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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbView = new System.Windows.Forms.TabControl();
            this.tbBonus = new System.Windows.Forms.TabPage();
            this.dgvBonus = new System.Windows.Forms.DataGridView();
            this.tbDeduct = new System.Windows.Forms.TabPage();
            this.dgvDeductions = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddPenalty = new System.Windows.Forms.Button();
            this.btnEditPenalty = new System.Windows.Forms.Button();
            this.btnDeletePenalty = new System.Windows.Forms.Button();
            this.tbView.SuspendLayout();
            this.tbBonus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonus)).BeginInit();
            this.tbDeduct.SuspendLayout();
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
            this.tbView.Size = new System.Drawing.Size(419, 426);
            this.tbView.TabIndex = 0;
            // 
            // tbBonus
            // 
            this.tbBonus.Controls.Add(this.dgvBonus);
            this.tbBonus.Location = new System.Drawing.Point(4, 22);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Padding = new System.Windows.Forms.Padding(3);
            this.tbBonus.Size = new System.Drawing.Size(411, 400);
            this.tbBonus.TabIndex = 0;
            this.tbBonus.Text = "Bonuses";
            this.tbBonus.UseVisualStyleBackColor = true;
            // 
            // dgvBonus
            // 
            this.dgvBonus.AllowUserToAddRows = false;
            this.dgvBonus.AllowUserToDeleteRows = false;
            this.dgvBonus.AllowUserToResizeColumns = false;
            this.dgvBonus.AllowUserToResizeRows = false;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBonus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle71;
            this.dgvBonus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle72.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBonus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle72;
            this.dgvBonus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle73.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBonus.DefaultCellStyle = dataGridViewCellStyle73;
            this.dgvBonus.Location = new System.Drawing.Point(6, 6);
            this.dgvBonus.Name = "dgvBonus";
            this.dgvBonus.ReadOnly = true;
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle74.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle74.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle74.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBonus.RowHeadersDefaultCellStyle = dataGridViewCellStyle74;
            this.dgvBonus.RowHeadersVisible = false;
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBonus.RowsDefaultCellStyle = dataGridViewCellStyle75;
            this.dgvBonus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBonus.Size = new System.Drawing.Size(399, 388);
            this.dgvBonus.TabIndex = 7;
            // 
            // tbDeduct
            // 
            this.tbDeduct.Controls.Add(this.dgvDeductions);
            this.tbDeduct.Location = new System.Drawing.Point(4, 22);
            this.tbDeduct.Name = "tbDeduct";
            this.tbDeduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbDeduct.Size = new System.Drawing.Size(411, 400);
            this.tbDeduct.TabIndex = 1;
            this.tbDeduct.Text = "Deductions";
            this.tbDeduct.UseVisualStyleBackColor = true;
            // 
            // dgvDeductions
            // 
            this.dgvDeductions.AllowUserToAddRows = false;
            this.dgvDeductions.AllowUserToDeleteRows = false;
            this.dgvDeductions.AllowUserToResizeColumns = false;
            this.dgvDeductions.AllowUserToResizeRows = false;
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDeductions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle76;
            this.dgvDeductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle77.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle77.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle77.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeductions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle77;
            this.dgvDeductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle78.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeductions.DefaultCellStyle = dataGridViewCellStyle78;
            this.dgvDeductions.Location = new System.Drawing.Point(6, 6);
            this.dgvDeductions.Name = "dgvDeductions";
            this.dgvDeductions.ReadOnly = true;
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle79.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle79.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle79.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeductions.RowHeadersDefaultCellStyle = dataGridViewCellStyle79;
            this.dgvDeductions.RowHeadersVisible = false;
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDeductions.RowsDefaultCellStyle = dataGridViewCellStyle80;
            this.dgvDeductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeductions.Size = new System.Drawing.Size(399, 388);
            this.dgvDeductions.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(476, 58);
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
            this.btnEdit.Location = new System.Drawing.Point(476, 193);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 67);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Accomplishment";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(476, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 67);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Accomplishment";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddPenalty
            // 
            this.btnAddPenalty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPenalty.Location = new System.Drawing.Point(655, 58);
            this.btnAddPenalty.Name = "btnAddPenalty";
            this.btnAddPenalty.Size = new System.Drawing.Size(146, 67);
            this.btnAddPenalty.TabIndex = 4;
            this.btnAddPenalty.Text = "Add Penalties";
            this.btnAddPenalty.UseVisualStyleBackColor = true;
            // 
            // btnEditPenalty
            // 
            this.btnEditPenalty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPenalty.Location = new System.Drawing.Point(655, 193);
            this.btnEditPenalty.Name = "btnEditPenalty";
            this.btnEditPenalty.Size = new System.Drawing.Size(146, 67);
            this.btnEditPenalty.TabIndex = 5;
            this.btnEditPenalty.Text = "Edit Penalties";
            this.btnEditPenalty.UseVisualStyleBackColor = true;
            // 
            // btnDeletePenalty
            // 
            this.btnDeletePenalty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePenalty.Location = new System.Drawing.Point(655, 334);
            this.btnDeletePenalty.Name = "btnDeletePenalty";
            this.btnDeletePenalty.Size = new System.Drawing.Size(146, 67);
            this.btnDeletePenalty.TabIndex = 6;
            this.btnDeletePenalty.Text = "Delete Penalties";
            this.btnDeletePenalty.UseVisualStyleBackColor = true;
            // 
            // frmAccomplishments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonus)).EndInit();
            this.tbDeduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeductions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbView;
        private System.Windows.Forms.TabPage tbBonus;
        private System.Windows.Forms.TabPage tbDeduct;
        public System.Windows.Forms.DataGridView dgvBonus;
        public System.Windows.Forms.DataGridView dgvDeductions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddPenalty;
        private System.Windows.Forms.Button btnEditPenalty;
        private System.Windows.Forms.Button btnDeletePenalty;
    }
}