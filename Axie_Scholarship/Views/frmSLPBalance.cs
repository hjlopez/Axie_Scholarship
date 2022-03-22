using Axie_Scholarship.API;
using Axie_Scholarship.Logs;
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
    public partial class frmSLPBalance : Form
    {
        Scholar scholar = null;
        SLPBalancePresenter<SLPBalanceViewModel> presenter;
        SLPBalanceViewModel vm;
        DataTable dt = new DataTable();
        public frmSLPBalance(Scholar scholar)
        {
            InitializeComponent();
            this.scholar = scholar;
            presenter = new SLPBalancePresenter<SLPBalanceViewModel>();
            vm = new SLPBalanceViewModel();
            vm.BonusCashOuts = new List<SLPBalanceViewModel.BonusCashOut>();
            vm.EarnCashOuts = new List<SLPBalanceViewModel.EarnCashOut>();

            LoadData();
        }

        private void LoadData()
        {
            vm.ScholarId = scholar.ScholarId;
            dt = presenter.LoadData(vm);

            int bonus = 0;
            decimal earned = 0;
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (!Convert.ToBoolean(row["IsExtraSLPApplied"]))
                    {
                        vm.BonusCashOuts.Add(new SLPBalanceViewModel.BonusCashOut { CashOutId = Convert.ToInt32(row["CashOutId"])});
                        bonus += Convert.ToInt32(row["ExtraSLP"]);
                    }

                    if (Convert.ToDecimal(row["SLPValueTransferred"]) != Convert.ToDecimal(row["ScholarSLP"]))
                    {
                        vm.EarnCashOuts.Add(new SLPBalanceViewModel.EarnCashOut { CashOutId = Convert.ToInt32(row["CashOutId"])});
                        earned += Math.Abs(Convert.ToDecimal(row["SLPValueTransferred"]) - Convert.ToDecimal(row["ScholarSLP"]));
                    }
                }

                txtBonusSLP.Text = bonus.ToString();
                txtEarnedSLP.Text = earned.ToString();
            }
        }

        private async void frmSLPBalance_Load(object sender, EventArgs e)
        {
            decimal php = 0;
            try
            {
                var slp = await SLPValue.GetSLPValue();
                if (slp != null)
                {
                    php = Math.Round(slp.market_data.current_price.php, 3);
                    lblSLPValue.Text = "Php " + php.ToString();
                    lblEarnedAmt.Text = "Php " + (Math.Round(Convert.ToDecimal(txtEarnedSLP.Text) * php, 2)).ToString();
                    lblBonusEarned.Text = "Php " + (Math.Round(Convert.ToInt32(txtBonusSLP.Text) * php, 2)).ToString();
                }
                else
                {
                    lblSLPValue.Text = "Php 0.00";
                    lblEarnedAmt.Text = "Php 0.00";
                    lblBonusEarned.Text = "Php 0.00";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                MessageBox.Show("Something went wrong while loading the current SLP Value. Please check logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblSLPValue.Text = "Php 0.00";
                lblEarnedAmt.Text = "Php 0.00";
                lblBonusEarned.Text = "Php 0.00";
            }
            EnableDisableButtons();
        }

        private void EnableDisableButtons()
        {
            btnBalanceCashout.Enabled = txtEarnedSLP.Text == "0" ? false : true;
            btnBonusCashout.Enabled = txtBonusSLP.Text == "0" ? false : true;
        }

        private void btnBalanceCashout_Click(object sender, EventArgs e)
        {
            if (vm.EarnCashOuts.Count != 0)
            {
                vm.IsEarnedCashout = true;
                if (presenter.Update(vm))
                {
                    MessageBox.Show("Earned SLP updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblEarnedAmt.Text = "Php 0.00";
                    txtEarnedSLP.Text = "0";
                    EnableDisableButtons();
                }
                else
                {
                    MessageBox.Show("Something went wrong during update! Please check the logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBonusCashout_Click(object sender, EventArgs e)
        {
            if (vm.BonusCashOuts.Count != 0)
            {
                vm.IsEarnedCashout = false;
                if (presenter.Update(vm))
                {
                    MessageBox.Show("Bonus SLP updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblBonusEarned.Text = "Php 0.00";
                    txtBonusSLP.Text = "0";
                    EnableDisableButtons();
                }
                else
                {
                    MessageBox.Show("Something went wrong during update! Please check the logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
