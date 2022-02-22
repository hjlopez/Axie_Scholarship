using Axie_Scholarship.Helpers;
using Axie_Scholarship.Models;
using Axie_Scholarship.Presenters;
using Axie_Scholarship.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.Views
{
    public partial class frmAddSLPEntry : Form
    {
        ScholarDetails scholarDetails;
        ScholarSLPPresenter<ScholarDetailViewModel> presenter;
        ScholarDetailViewModel vm;
        long scholarId;
        public frmAddSLPEntry(long scholarId)
        {
            InitializeComponent();
            this.scholarId = scholarId;
            this.HelpButtonClicked += frmAddSLPEntry_HelpButtonClicked;
            vm = new ScholarDetailViewModel();
            scholarDetails = new ScholarDetails();
            presenter = new ScholarSLPPresenter<ScholarDetailViewModel>();
            txtSLPEarned.KeyPress += new KeyPressEventHandler(txtSLPEarned_KeyPress);
            txtSLPEarned.TextChanged += new EventHandler(txtSLPEarned_TextChanged);
            txtSLPStart.TextChanged += new EventHandler(txtSLPStart_TextChanged);
            //txtSLPStart.LostFocus += new EventHandler(txtSLPStart_LostFocus);
            txtSLPEnd.TextChanged += new EventHandler(txtSLPEnd_TextChanged);
            //txtSLPEnd.LostFocus += new EventHandler(txtSLPEnd_LostFocus);
            txtSLPEarned.LostFocus += new EventHandler(txtSLPEarned_LostFocus);
        }

        //private void txtSLPStart_LostFocus(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void txtSLPEnd_LostFocus(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void txtSLPEarned_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSLPEarned_LostFocus(object sender, EventArgs e)
        {
            //if (txtSLPEarned.Text == string.Empty || !ExpressionsHelper.NumbersOnly(txtSLPEarned.Text))
            //{
            //    MessageBox.Show("Please input numbers only.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    if (txtSLPEarned.Text.Length == 1) txtSLPEarned.Text = "0";
            //    txtSLPEarned.Focus();
            //}
        }

        private void txtSLPEnd_TextChanged(object sender, EventArgs e)
        {
            if (!ExpressionsHelper.NumbersOnly(txtSLPEnd.Text))
            {
                ValidateFields(true);
                return;
            }
            Validate();
            if (txtSLPStart.Text != "0" && txtSLPEnd.Text != "0")
            {
                txtSLPEarned.Text = presenter.ComputeEarnedSLP(ConversionHelper.ReturnZeroIfNull(txtSLPStart.Text), ConversionHelper.ReturnZeroIfNull(txtSLPEnd.Text));
            }
        }

        private void txtSLPStart_TextChanged(object sender, EventArgs e)
        {
            if (!ExpressionsHelper.NumbersOnly(txtSLPStart.Text))
            {
                ValidateFields(true);
                return;
            }
            ValidateFields();
            if (txtSLPStart.Text != "0" && txtSLPEnd.Text != "0")
            {
                txtSLPEarned.Text = presenter.ComputeEarnedSLP(ConversionHelper.ReturnZeroIfNull(txtSLPStart.Text), ConversionHelper.ReturnZeroIfNull(txtSLPEnd.Text));
            }
            
        }

        private void txtSLPEarned_KeyPress(object sender, EventArgs e)
        {
            txtSLPEnd.Text = "0";
            txtSLPStart.Text = "0";
        }

        private void frmAddSLPEntry_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("If you want to input the start and end SLP for the day, it will automatically compute the earned SLP. You can also input manually the earned SLP and it will clear the values for the start and end SLP field. Start and End SLP fields are optional. " + 
                "You may also input the PVP record of the scholar and current MMR if you wish.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vm.ScholarDetails = new ScholarDetails();
            var success = false;
            vm.ScholarDetails.DateEarned = dtpEarned.Value.ToString("yyyyMMdd");
            vm.ScholarDetails.ScholarId = this.scholarId;
            vm.ScholarDetails.SLPStart = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtSLPStart.Text));
            vm.ScholarDetails.SLPEnd = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtSLPEnd.Text));
            vm.ScholarDetails.SLPEarnedToday = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtSLPEarned.Text));
            vm.ScholarDetails.PVPWin = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtWins.Text));
            vm.ScholarDetails.PVPLose = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtLoss.Text));
            vm.ScholarDetails.PVPDraw = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtDraws.Text));
            vm.ScholarDetails.CurrentMMR = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtMMR.Text));

            if (vm.ScholarDetails.SLPEarnedToday == 0)
            {
                DialogResult result = MessageBox.Show("SLP earned today is 0. Do you want to save this entry?", "Zero SLP", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    success = presenter.Insert(vm);
                }
               
            }
            else
            {
                success = presenter.Insert(vm);
            }

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
           
        }

        private void txtSLPEarned_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSLPEarned.Text == string.Empty || !ExpressionsHelper.NumbersOnly(txtSLPEarned.Text))
            {
                ValidateFields(true);
                return;
            }
            ValidateFields();
        }

        private void ValidateFields(bool isVisible = false)
        {
            lblMessage.Visible = isVisible;
            if (isVisible)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void txtWins_TextChanged(object sender, EventArgs e)
        {
            if (txtWins.Text == string.Empty || !ExpressionsHelper.NumbersOnly(txtWins.Text))
            {
                ValidateFields(true);
                return;
            }
            ValidateFields();
        }

        private void txtLoss_TextChanged(object sender, EventArgs e)
        {
            if (txtLoss.Text == string.Empty || !ExpressionsHelper.NumbersOnly(txtLoss.Text))
            {
                ValidateFields(true);
                return;
            }
            ValidateFields();
        }

        private void txtDraws_TextChanged(object sender, EventArgs e)
        {
            if (txtDraws.Text == string.Empty || !ExpressionsHelper.NumbersOnly(txtDraws.Text))
            {
                ValidateFields(true);
                return;
            }
            ValidateFields();
        }

        private void txtMMR_TextChanged(object sender, EventArgs e)
        {
            if (txtMMR.Text == string.Empty || !ExpressionsHelper.NumbersOnly(txtMMR.Text))
            {
                ValidateFields(true);
                return;
            }
            ValidateFields();
        }
    }
}
