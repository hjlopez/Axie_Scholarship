using Axie_Scholarship.Helpers;
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
using Axie_Scholarship.Models;
using Axie_Scholarship.Presenters;

namespace Axie_Scholarship.Views.Accomplishments
{
    public partial class frmAddAccomplishment : Form
    {
        AccomplishmentViewModel vm = null;
        Models.Accomplishments model = null;
        AccomplishmentPresenter<Models.Accomplishments> presenter = null;
        int selected = 0;
        public frmAddAccomplishment()
        {
            InitializeComponent();
            txtWinDay.TextChanged += new EventHandler(OnceChanged);
            txtLossOnce.TextChanged += new EventHandler(OnceChanged);
            txtDrawOnce.TextChanged += new EventHandler(OnceChanged);

            txtReward.TextChanged += new EventHandler(RewardChanged);
            rbExact.CheckedChanged += new EventHandler(RewardChanged);
            rbPercent.CheckedChanged += new EventHandler(RewardChanged);

            txtWinCustom.TextChanged += new EventHandler(CustomChanged);
            txtLossCustom.TextChanged += new EventHandler(CustomChanged);
            txtDrawCustom.TextChanged += new EventHandler(CustomChanged);
            nmFrequency.ValueChanged += new EventHandler(CustomChanged);

            txtWinTotal.TextChanged += new EventHandler(TotalChanged);
            txtLossTotal.TextChanged += new EventHandler(TotalChanged);
            txtDrawTotal.TextChanged += new EventHandler(TotalChanged);
            chkWinningPercent.CheckedChanged += new EventHandler(TotalChanged);

            vm = new AccomplishmentViewModel();
            model = new Models.Accomplishments();
            presenter = new AccomplishmentPresenter<Models.Accomplishments>("PVPBonus");
            vm.Record = new AccomplishmentViewModel.PVPRecord();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RewardChanged(object sender, EventArgs e)
        {
            CreateData();
            if (tbView.SelectedTab == tbView.TabPages["tbRecord"])
            {
                if (presenter.Validate(vm))
                {
                    lblError.Visible = false;
                    switch (selected)
                    {
                        case 1:
                            txtOnce.Text = presenter.GenerateDescription(vm);
                            break;
                        case 2:
                            txtCustom.Text = presenter.GenerateDescription(vm);
                            break;
                        case 3:
                            txtTotal.Text = presenter.GenerateDescription(vm);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    lblError.Visible = true;
                }
               
            }
        }

        private void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDay.Checked)
            {
                grpOnce.Enabled = true;
                grpReward.Enabled = true;
                btnSave.Enabled = true;
                selected = 1;
            }
            else
                grpOnce.Enabled = false;
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustom.Checked)
            {
                grpCustom.Enabled = true;
                grpReward.Enabled = true;
                btnSave.Enabled = true;
                selected = 2;
            }
            else
                grpCustom.Enabled = false;
        }

        private void rbCheckout_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheckout.Checked)
            {
                grpTotal.Enabled = true;
                grpReward.Enabled = true;
                btnSave.Enabled = true;
                selected = 3;
            }
            else
                grpTotal.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!rbPercent.Checked && !rbExact.Checked)
            {
                MessageBox.Show("Select a reward!");
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Input a name!");
                return;
            }
            if (tbView.SelectedTab == tbView.TabPages["tbRecord"])
            {
                model.IsPenalty = false;
                model.IsPercent = vm.Record.IsPercent;
                model.Name = txtName.Text;
                model.Reward = model.IsPercent ? (vm.Record.Reward / 100) : vm.Record.Reward;
                switch (selected)
                {
                    case 1:
                        model.Description = txtOnce.Text;
                        break;
                    case 2:
                        model.Description = txtCustom.Text;
                        break;
                    case 3:
                        model.Description = txtTotal.Text;
                        break;
                    default:
                        break;
                }
                
                if (presenter.Insert(model))
                {
                    MessageBox.Show("Inserted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving! Please check logs at C:\\Axie Logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkWinningPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWinningPercent.Checked)
            {
                txtWinTotal.Text = "0";
                txtLossTotal.Text = "0";
                txtDrawTotal.Text = "0";
            }
        }

        private void CustomChanged(object sender, EventArgs e)
        {
            CreateData();
            vm.Record.Frequency = ExpressionsHelper.NumbersOnly(nmFrequency.Value.ToString()) ? Convert.ToInt32(nmFrequency.Value) : 0;
            if (presenter.Validate(vm))
            {
                lblError.Visible = false;
                txtCustom.Text = presenter.GenerateDescription(vm);
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void TotalChanged(object sender, EventArgs e)
        {
            CreateData();
            vm.Record.HasWinningPercentage = chkWinningPercent.Checked;
            if (presenter.Validate(vm))
            {
                lblError.Visible = false;
                txtTotal.Text = presenter.GenerateDescription(vm);
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void OnceChanged(object sender, EventArgs e)
        {
            CreateData();
            if (presenter.Validate(vm))
            {
                lblError.Visible = false;
                txtOnce.Text = presenter.GenerateDescription(vm);
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void CreateData()
        {
            switch (selected)
            {
                case 1:
                    vm.Record.Wins = ExpressionsHelper.NumbersOnly(txtWinDay.Text) ? Convert.ToInt32(txtWinDay.Text) : 0;
                    vm.Record.Loss = ExpressionsHelper.NumbersOnly(txtLossOnce.Text) ? Convert.ToInt32(txtLossOnce.Text) : 0;
                    vm.Record.Draw = ExpressionsHelper.NumbersOnly(txtDrawOnce.Text) ? Convert.ToInt32(txtDrawOnce.Text) : 0;
                    vm.Record.Type = selected;
                    vm.Record.IsPercent = rbPercent.Checked;
                    vm.Record.Reward = ExpressionsHelper.NumbersOnly(txtReward.Text) ? Convert.ToDecimal(txtReward.Text) : 0;
                    break;
                case 2:
                    vm.Record.Wins = ExpressionsHelper.NumbersOnly(txtWinCustom.Text) ? Convert.ToInt32(txtWinCustom.Text) : 0;
                    vm.Record.Loss = ExpressionsHelper.NumbersOnly(txtLossCustom.Text) ? Convert.ToInt32(txtLossCustom.Text) : 0;
                    vm.Record.Draw = ExpressionsHelper.NumbersOnly(txtDrawCustom.Text) ? Convert.ToInt32(txtDrawCustom.Text) : 0;
                    vm.Record.Type = selected;
                    vm.Record.IsPercent = rbPercent.Checked;
                    vm.Record.Reward = ExpressionsHelper.NumbersOnly(txtReward.Text) ? Convert.ToDecimal(txtReward.Text) : 0;
                    break;
                case 3:
                    vm.Record.Wins = ExpressionsHelper.NumbersOnly(txtWinTotal.Text) ? Convert.ToInt32(txtWinTotal.Text) : 0;
                    vm.Record.Loss = ExpressionsHelper.NumbersOnly(txtLossTotal.Text) ? Convert.ToInt32(txtLossTotal.Text) : 0;
                    vm.Record.Draw = ExpressionsHelper.NumbersOnly(txtDrawTotal.Text) ? Convert.ToInt32(txtDrawTotal.Text) : 0;
                    vm.Record.Type = selected;
                    vm.Record.IsPercent = rbPercent.Checked;
                    vm.Record.Reward = ExpressionsHelper.NumbersOnly(txtReward.Text) ? Convert.ToDecimal(txtReward.Text) : 0;
                    break;
                default:
                    break;
            }
            
        }

        private void txtWinDay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
