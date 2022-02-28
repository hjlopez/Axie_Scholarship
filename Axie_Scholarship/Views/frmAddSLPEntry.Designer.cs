namespace Axie_Scholarship.Views
{
    partial class frmAddSLPEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEarned = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSLPStart = new System.Windows.Forms.TextBox();
            this.txtSLPEnd = new System.Windows.Forms.TextBox();
            this.txtSLPEarned = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.txtLoss = new System.Windows.Forms.TextBox();
            this.txtDraws = new System.Windows.Forms.TextBox();
            this.txtMMR = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Earned:";
            // 
            // dtpEarned
            // 
            this.dtpEarned.Location = new System.Drawing.Point(112, 12);
            this.dtpEarned.Name = "dtpEarned";
            this.dtpEarned.Size = new System.Drawing.Size(200, 20);
            this.dtpEarned.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SLP Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SLP End:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SLP Earned:";
            // 
            // txtSLPStart
            // 
            this.txtSLPStart.Location = new System.Drawing.Point(78, 60);
            this.txtSLPStart.Name = "txtSLPStart";
            this.txtSLPStart.Size = new System.Drawing.Size(64, 20);
            this.txtSLPStart.TabIndex = 2;
            this.txtSLPStart.Text = "0";
            this.txtSLPStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSLPEnd
            // 
            this.txtSLPEnd.Location = new System.Drawing.Point(349, 60);
            this.txtSLPEnd.Name = "txtSLPEnd";
            this.txtSLPEnd.Size = new System.Drawing.Size(64, 20);
            this.txtSLPEnd.TabIndex = 3;
            this.txtSLPEnd.Text = "0";
            this.txtSLPEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSLPEarned
            // 
            this.txtSLPEarned.Location = new System.Drawing.Point(226, 91);
            this.txtSLPEarned.Name = "txtSLPEarned";
            this.txtSLPEarned.Size = new System.Drawing.Size(64, 20);
            this.txtSLPEarned.TabIndex = 4;
            this.txtSLPEarned.Text = "0";
            this.txtSLPEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSLPEarned.TextChanged += new System.EventHandler(this.txtSLPEarned_TextChanged_1);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(78, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(260, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Wins";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Losses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Draws";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "MMR";
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(20, 133);
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(45, 20);
            this.txtWins.TabIndex = 11;
            this.txtWins.Text = "0";
            this.txtWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWins.TextChanged += new System.EventHandler(this.txtWins_TextChanged);
            // 
            // txtLoss
            // 
            this.txtLoss.Location = new System.Drawing.Point(97, 133);
            this.txtLoss.Name = "txtLoss";
            this.txtLoss.Size = new System.Drawing.Size(45, 20);
            this.txtLoss.TabIndex = 12;
            this.txtLoss.Text = "0";
            this.txtLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoss.TextChanged += new System.EventHandler(this.txtLoss_TextChanged);
            // 
            // txtDraws
            // 
            this.txtDraws.Location = new System.Drawing.Point(172, 133);
            this.txtDraws.Name = "txtDraws";
            this.txtDraws.Size = new System.Drawing.Size(45, 20);
            this.txtDraws.TabIndex = 13;
            this.txtDraws.Text = "0";
            this.txtDraws.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDraws.TextChanged += new System.EventHandler(this.txtDraws_TextChanged);
            // 
            // txtMMR
            // 
            this.txtMMR.Location = new System.Drawing.Point(307, 133);
            this.txtMMR.Name = "txtMMR";
            this.txtMMR.Size = new System.Drawing.Size(89, 20);
            this.txtMMR.TabIndex = 14;
            this.txtMMR.Text = "0";
            this.txtMMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMMR.TextChanged += new System.EventHandler(this.txtMMR_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(142, 223);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(129, 13);
            this.lblMessage.TabIndex = 52;
            this.lblMessage.Text = "Please check your inputs!";
            this.lblMessage.Visible = false;
            // 
            // frmAddSLPEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 244);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMMR);
            this.Controls.Add(this.txtDraws);
            this.Controls.Add(this.txtLoss);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSLPEarned);
            this.Controls.Add(this.txtSLPEnd);
            this.Controls.Add(this.txtSLPStart);
            this.Controls.Add(this.dtpEarned);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddSLPEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEarned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSLPStart;
        private System.Windows.Forms.TextBox txtSLPEnd;
        private System.Windows.Forms.TextBox txtSLPEarned;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.TextBox txtLoss;
        private System.Windows.Forms.TextBox txtDraws;
        private System.Windows.Forms.TextBox txtMMR;
        private System.Windows.Forms.Label lblMessage;
    }
}