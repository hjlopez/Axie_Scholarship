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
        public frmSLPBalance(Scholar scholar)
        {
            InitializeComponent();
            this.scholar = scholar;
            presenter = new SLPBalancePresenter<SLPBalanceViewModel>();
            vm = new SLPBalanceViewModel();

            LoadData();
        }

        private void LoadData()
        {
            vm.ScholarId = scholar.ScholarId;
            var dt = presenter.LoadData(vm);

            int bonus = 0;
            decimal earned = 0;
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (!Convert.ToBoolean(row["IsExtraSLPApplied"]))
                    {
                        bonus += Convert.ToInt32(row["ExtraSLP"]);
                    }

                    if (Convert.ToDecimal(row["SLPValueTransferred"]) != Convert.ToDecimal(row["ScholarSLP"]))
                    {
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
    }
}
