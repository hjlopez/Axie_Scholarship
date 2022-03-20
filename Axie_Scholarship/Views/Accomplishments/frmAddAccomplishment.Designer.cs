namespace Axie_Scholarship.Views.Accomplishments
{
    partial class frmAddAccomplishment
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
            this.tbView = new System.Windows.Forms.TabControl();
            this.tbRecord = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.rbCheckout = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDrawTotal = new System.Windows.Forms.TextBox();
            this.txtLossTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWinTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkWinningPercent = new System.Windows.Forms.CheckBox();
            this.grpCustom = new System.Windows.Forms.GroupBox();
            this.nmFrequency = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.txtDrawCustom = new System.Windows.Forms.TextBox();
            this.txtLossCustom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWinCustom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpOnce = new System.Windows.Forms.GroupBox();
            this.txtOnce = new System.Windows.Forms.TextBox();
            this.txtDrawOnce = new System.Windows.Forms.TextBox();
            this.txtLossOnce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWinDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSLP = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpReward = new System.Windows.Forms.GroupBox();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.rbExact = new System.Windows.Forms.RadioButton();
            this.rbPercent = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tbView.SuspendLayout();
            this.tbRecord.SuspendLayout();
            this.grpTotal.SuspendLayout();
            this.grpCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFrequency)).BeginInit();
            this.grpOnce.SuspendLayout();
            this.grpReward.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbView
            // 
            this.tbView.Controls.Add(this.tbRecord);
            this.tbView.Controls.Add(this.tbSLP);
            this.tbView.Location = new System.Drawing.Point(12, 12);
            this.tbView.Name = "tbView";
            this.tbView.SelectedIndex = 0;
            this.tbView.Size = new System.Drawing.Size(847, 369);
            this.tbView.TabIndex = 1;
            // 
            // tbRecord
            // 
            this.tbRecord.Controls.Add(this.lblError);
            this.tbRecord.Controls.Add(this.rbCheckout);
            this.tbRecord.Controls.Add(this.rbCustom);
            this.tbRecord.Controls.Add(this.rbDay);
            this.tbRecord.Controls.Add(this.btnHelp);
            this.tbRecord.Controls.Add(this.grpTotal);
            this.tbRecord.Controls.Add(this.grpCustom);
            this.tbRecord.Controls.Add(this.grpOnce);
            this.tbRecord.Location = new System.Drawing.Point(4, 22);
            this.tbRecord.Name = "tbRecord";
            this.tbRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbRecord.Size = new System.Drawing.Size(839, 343);
            this.tbRecord.TabIndex = 0;
            this.tbRecord.Text = "PVP Records";
            this.tbRecord.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(369, 310);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(167, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "* Please check your inputs!!";
            this.lblError.Visible = false;
            // 
            // rbCheckout
            // 
            this.rbCheckout.AutoSize = true;
            this.rbCheckout.Location = new System.Drawing.Point(596, 83);
            this.rbCheckout.Name = "rbCheckout";
            this.rbCheckout.Size = new System.Drawing.Size(14, 13);
            this.rbCheckout.TabIndex = 6;
            this.rbCheckout.TabStop = true;
            this.rbCheckout.UseVisualStyleBackColor = true;
            this.rbCheckout.CheckedChanged += new System.EventHandler(this.rbCheckout_CheckedChanged);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(313, 83);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(14, 13);
            this.rbCustom.TabIndex = 5;
            this.rbCustom.TabStop = true;
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(23, 83);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(14, 13);
            this.rbDay.TabIndex = 4;
            this.rbDay.TabStop = true;
            this.rbDay.UseVisualStyleBackColor = true;
            this.rbDay.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Location = new System.Drawing.Point(753, 6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.txtTotal);
            this.grpTotal.Controls.Add(this.txtDrawTotal);
            this.grpTotal.Controls.Add(this.txtLossTotal);
            this.grpTotal.Controls.Add(this.label8);
            this.grpTotal.Controls.Add(this.label9);
            this.grpTotal.Controls.Add(this.txtWinTotal);
            this.grpTotal.Controls.Add(this.label10);
            this.grpTotal.Controls.Add(this.chkWinningPercent);
            this.grpTotal.Enabled = false;
            this.grpTotal.Location = new System.Drawing.Point(628, 33);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(200, 255);
            this.grpTotal.TabIndex = 2;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total ";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(6, 163);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(188, 76);
            this.txtTotal.TabIndex = 15;
            // 
            // txtDrawTotal
            // 
            this.txtDrawTotal.Location = new System.Drawing.Point(97, 125);
            this.txtDrawTotal.Name = "txtDrawTotal";
            this.txtDrawTotal.Size = new System.Drawing.Size(48, 20);
            this.txtDrawTotal.TabIndex = 10;
            this.txtDrawTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLossTotal
            // 
            this.txtLossTotal.Location = new System.Drawing.Point(97, 83);
            this.txtLossTotal.Name = "txtLossTotal";
            this.txtLossTotal.Size = new System.Drawing.Size(48, 20);
            this.txtLossTotal.TabIndex = 9;
            this.txtLossTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Draw:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Loss:";
            // 
            // txtWinTotal
            // 
            this.txtWinTotal.Location = new System.Drawing.Point(97, 43);
            this.txtWinTotal.Name = "txtWinTotal";
            this.txtWinTotal.Size = new System.Drawing.Size(48, 20);
            this.txtWinTotal.TabIndex = 6;
            this.txtWinTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Wins:";
            // 
            // chkWinningPercent
            // 
            this.chkWinningPercent.AutoSize = true;
            this.chkWinningPercent.Location = new System.Drawing.Point(21, 19);
            this.chkWinningPercent.Name = "chkWinningPercent";
            this.chkWinningPercent.Size = new System.Drawing.Size(145, 17);
            this.chkWinningPercent.TabIndex = 0;
            this.chkWinningPercent.Text = "Has Winning Percentage";
            this.chkWinningPercent.UseVisualStyleBackColor = true;
            this.chkWinningPercent.CheckedChanged += new System.EventHandler(this.chkWinningPercent_CheckedChanged);
            // 
            // grpCustom
            // 
            this.grpCustom.Controls.Add(this.nmFrequency);
            this.grpCustom.Controls.Add(this.label7);
            this.grpCustom.Controls.Add(this.txtCustom);
            this.grpCustom.Controls.Add(this.txtDrawCustom);
            this.grpCustom.Controls.Add(this.txtLossCustom);
            this.grpCustom.Controls.Add(this.label4);
            this.grpCustom.Controls.Add(this.label5);
            this.grpCustom.Controls.Add(this.txtWinCustom);
            this.grpCustom.Controls.Add(this.label6);
            this.grpCustom.Enabled = false;
            this.grpCustom.Location = new System.Drawing.Point(342, 33);
            this.grpCustom.Name = "grpCustom";
            this.grpCustom.Size = new System.Drawing.Size(200, 255);
            this.grpCustom.TabIndex = 1;
            this.grpCustom.TabStop = false;
            this.grpCustom.Text = "Custom";
            this.grpCustom.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // nmFrequency
            // 
            this.nmFrequency.Location = new System.Drawing.Point(101, 107);
            this.nmFrequency.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmFrequency.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmFrequency.Name = "nmFrequency";
            this.nmFrequency.Size = new System.Drawing.Size(49, 20);
            this.nmFrequency.TabIndex = 14;
            this.nmFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmFrequency.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Frequency:";
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(6, 163);
            this.txtCustom.Multiline = true;
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.ReadOnly = true;
            this.txtCustom.Size = new System.Drawing.Size(188, 76);
            this.txtCustom.TabIndex = 12;
            // 
            // txtDrawCustom
            // 
            this.txtDrawCustom.Location = new System.Drawing.Point(102, 80);
            this.txtDrawCustom.Name = "txtDrawCustom";
            this.txtDrawCustom.Size = new System.Drawing.Size(48, 20);
            this.txtDrawCustom.TabIndex = 11;
            this.txtDrawCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLossCustom
            // 
            this.txtLossCustom.Location = new System.Drawing.Point(102, 55);
            this.txtLossCustom.Name = "txtLossCustom";
            this.txtLossCustom.Size = new System.Drawing.Size(48, 20);
            this.txtLossCustom.TabIndex = 10;
            this.txtLossCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Draw:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loss:";
            // 
            // txtWinCustom
            // 
            this.txtWinCustom.Location = new System.Drawing.Point(102, 29);
            this.txtWinCustom.Name = "txtWinCustom";
            this.txtWinCustom.Size = new System.Drawing.Size(48, 20);
            this.txtWinCustom.TabIndex = 7;
            this.txtWinCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Wins:";
            // 
            // grpOnce
            // 
            this.grpOnce.Controls.Add(this.txtOnce);
            this.grpOnce.Controls.Add(this.txtDrawOnce);
            this.grpOnce.Controls.Add(this.txtLossOnce);
            this.grpOnce.Controls.Add(this.label3);
            this.grpOnce.Controls.Add(this.label2);
            this.grpOnce.Controls.Add(this.txtWinDay);
            this.grpOnce.Controls.Add(this.label1);
            this.grpOnce.Enabled = false;
            this.grpOnce.Location = new System.Drawing.Point(53, 33);
            this.grpOnce.Name = "grpOnce";
            this.grpOnce.Size = new System.Drawing.Size(200, 255);
            this.grpOnce.TabIndex = 0;
            this.grpOnce.TabStop = false;
            this.grpOnce.Text = "Once Per Cutoff";
            // 
            // txtOnce
            // 
            this.txtOnce.Location = new System.Drawing.Point(6, 163);
            this.txtOnce.Multiline = true;
            this.txtOnce.Name = "txtOnce";
            this.txtOnce.ReadOnly = true;
            this.txtOnce.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOnce.Size = new System.Drawing.Size(188, 76);
            this.txtOnce.TabIndex = 5;
            // 
            // txtDrawOnce
            // 
            this.txtDrawOnce.Location = new System.Drawing.Point(96, 111);
            this.txtDrawOnce.Name = "txtDrawOnce";
            this.txtDrawOnce.Size = new System.Drawing.Size(48, 20);
            this.txtDrawOnce.TabIndex = 4;
            this.txtDrawOnce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLossOnce
            // 
            this.txtLossOnce.Location = new System.Drawing.Point(96, 69);
            this.txtLossOnce.Name = "txtLossOnce";
            this.txtLossOnce.Size = new System.Drawing.Size(48, 20);
            this.txtLossOnce.TabIndex = 3;
            this.txtLossOnce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Draw:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loss:";
            // 
            // txtWinDay
            // 
            this.txtWinDay.Location = new System.Drawing.Point(96, 29);
            this.txtWinDay.Name = "txtWinDay";
            this.txtWinDay.Size = new System.Drawing.Size(48, 20);
            this.txtWinDay.TabIndex = 1;
            this.txtWinDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWinDay.TextChanged += new System.EventHandler(this.txtWinDay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wins:";
            // 
            // tbSLP
            // 
            this.tbSLP.Location = new System.Drawing.Point(4, 22);
            this.tbSLP.Name = "tbSLP";
            this.tbSLP.Padding = new System.Windows.Forms.Padding(3);
            this.tbSLP.Size = new System.Drawing.Size(839, 343);
            this.tbSLP.TabIndex = 1;
            this.tbSLP.Text = "SLP/MMR";
            this.tbSLP.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(920, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 51);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(920, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 51);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE ENTRY";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpReward
            // 
            this.grpReward.Controls.Add(this.txtReward);
            this.grpReward.Controls.Add(this.rbExact);
            this.grpReward.Controls.Add(this.rbPercent);
            this.grpReward.Enabled = false;
            this.grpReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReward.Location = new System.Drawing.Point(861, 110);
            this.grpReward.Name = "grpReward";
            this.grpReward.Size = new System.Drawing.Size(200, 87);
            this.grpReward.TabIndex = 7;
            this.grpReward.TabStop = false;
            this.grpReward.Text = "Reward";
            // 
            // txtReward
            // 
            this.txtReward.Location = new System.Drawing.Point(64, 52);
            this.txtReward.Name = "txtReward";
            this.txtReward.Size = new System.Drawing.Size(63, 20);
            this.txtReward.TabIndex = 2;
            this.txtReward.Text = "1";
            this.txtReward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbExact
            // 
            this.rbExact.AutoSize = true;
            this.rbExact.Location = new System.Drawing.Point(132, 19);
            this.rbExact.Name = "rbExact";
            this.rbExact.Size = new System.Drawing.Size(57, 17);
            this.rbExact.TabIndex = 1;
            this.rbExact.Text = "Exact\r\n";
            this.rbExact.UseVisualStyleBackColor = true;
            // 
            // rbPercent
            // 
            this.rbPercent.AutoSize = true;
            this.rbPercent.Location = new System.Drawing.Point(10, 19);
            this.rbPercent.Name = "rbPercent";
            this.rbPercent.Size = new System.Drawing.Size(69, 17);
            this.rbPercent.TabIndex = 0;
            this.rbPercent.Text = "Percent";
            this.rbPercent.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(868, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Input Name for Entry:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(871, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 16;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddAccomplishment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 399);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpReward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAccomplishment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Accomplishment";
            this.tbView.ResumeLayout(false);
            this.tbRecord.ResumeLayout(false);
            this.tbRecord.PerformLayout();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.grpCustom.ResumeLayout(false);
            this.grpCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFrequency)).EndInit();
            this.grpOnce.ResumeLayout(false);
            this.grpOnce.PerformLayout();
            this.grpReward.ResumeLayout(false);
            this.grpReward.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbView;
        private System.Windows.Forms.TabPage tbRecord;
        private System.Windows.Forms.TabPage tbSLP;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.GroupBox grpCustom;
        private System.Windows.Forms.GroupBox grpOnce;
        private System.Windows.Forms.RadioButton rbCheckout;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.TextBox txtWinDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrawOnce;
        private System.Windows.Forms.TextBox txtLossOnce;
        private System.Windows.Forms.TextBox txtOnce;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.TextBox txtDrawCustom;
        private System.Windows.Forms.TextBox txtLossCustom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWinCustom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDrawTotal;
        private System.Windows.Forms.TextBox txtLossTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWinTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkWinningPercent;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.NumericUpDown nmFrequency;
        private System.Windows.Forms.GroupBox grpReward;
        private System.Windows.Forms.RadioButton rbExact;
        private System.Windows.Forms.RadioButton rbPercent;
        private System.Windows.Forms.TextBox txtReward;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
    }
}