using Axie_Scholarship.API;
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
    public partial class frmCashOut : Form
    {
        List<DataGridViewRow> rowCollection;
        Scholar scholar;
        ScholarSLPPresenter<ScholarDetailViewModel> presenter;
        DataGridViewSelectedRowCollection r;
        SLPCoinViewModel slp;
        string minDate = "";
        string maxDate = "";
        string origSLP = "";
        int reward = 0;
        decimal php = 0;
        decimal amt = 0;
        public frmCashOut(List<DataGridViewRow> rows, DataGridViewSelectedRowCollection r2, Scholar scholar)
        {
            InitializeComponent();
            rowCollection = rows;
            this.scholar = scholar;
            this.r = r2;
            presenter = new ScholarSLPPresenter<ScholarDetailViewModel>();
            chkSLPCashOut.Checked = this.scholar.IsSLPCashout;
            GetMinAndMaxDate();
            LoadDetails();
            DetermineMissingDates();
            LoadAccomplishments();
            if (this.scholar.IsSLPCashout)
            {
                chkApply.Enabled = false;
            }
            else
            {
                if (lblAdjSLP.Text == "0") chkApply.Enabled = false;
                else chkApply.Enabled = true;
            }
            

            dgvBonus.CellContentClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
            dgvPenalty.CellContentClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
            dgvOthers.CellContentClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
        }

        private void LoadAccomplishments()
        {
            EditColumns();
            var p = new AccomplishmentPresenter<Models.Accomplishments>("");
            var dt = p.LoadData(null);

            // populate tabs
            foreach (DataRow row in dt.Rows)
            {
                
                if (!Convert.ToBoolean(row["IsPenalty"]))
                {
                    // check if entry is accomplished
                    if (p.IsAccomplished(row["Description"].ToString(), rowCollection))
                    {
                        int value = Convert.ToBoolean(row["IsPercent"]) ? Convert.ToInt32(Convert.ToInt32(lblTotalSLP.Text) * Convert.ToDecimal(row["Reward"])) : Convert.ToInt32(row["Reward"]);
                        dgvBonus.Rows.Add(row["Name"], value, true);
                        reward += value;
                        
                    }
                    
                }
            }
            lblAdjSLP.Text = (Convert.ToInt32(lblAdjSLP.Text) + (reward)).ToString();
            // get manual rewards
            var dtManualRewards = presenter.GetScholarExtrasForExcelGeneration(scholar.ScholarId);
            if (dtManualRewards != null)
            {
                foreach (DataRow data in dtManualRewards.Rows)
                {
                    dgvOthers.Rows.Add(data["Reason"], data["SLPValue"], true);
                }
            }
           
        }

        private void EditColumns()
        {
            dgvBonus.Columns[0].ReadOnly = true;
            dgvBonus.Columns[1].ReadOnly = true;
            dgvBonus.Columns[2].ReadOnly = false;

            dgvPenalty.Columns[0].ReadOnly = true;
            dgvPenalty.Columns[1].ReadOnly = true;
            dgvPenalty.Columns[2].ReadOnly = false;

            dgvOthers.Columns[0].ReadOnly = true;
            dgvOthers.Columns[1].ReadOnly = true;
            dgvOthers.Columns[2].ReadOnly = false;
        }

        private void LoadDetails(bool withAdj = false)
        {
            int share = scholar.ScholarCut;
            grpScholar.Text = scholar.ScholarName + " Earnings";
            lblShare.Text = share.ToString() + "%";
            if (origSLP == "")
            {
                origSLP = presenter.ComputeTotalSLP(rowCollection).ToString();
            }

            if (withAdj)
            {
                lblTotalSLP.Text = (Convert.ToInt32(origSLP) + Convert.ToInt32(lblAdjSLP.Text)).ToString();
            }
            else
            {
                lblTotalSLP.Text = origSLP;
            }

            lblScholarSLP.Text = chkSLPCashOut.Checked ?
                (Convert.ToInt32(Math.Floor(Convert.ToInt32(lblTotalSLP.Text) * (Convert.ToDecimal(share) / 100))).ToString()) :
                (Convert.ToInt32(lblTotalSLP.Text) * (Convert.ToDecimal(share) / 100)).ToString();

            lblAdjSLP.Text = (presenter.GetScholarExtrasById(scholar.ScholarId) + reward).ToString();

            frmCashOut_Load(null, null);
        }

        private void DetermineMissingDates()
        {
            var start = Convert.ToDateTime(lblDateFrom.Text);
            var end = Convert.ToDateTime(lblDateTo.Text);
            var currLoopDate = start;

            while (currLoopDate.Date < end.Date)
            {
                // check if current loop date is in list of rows selected
                var exist = rowCollection.Where(x => Convert.ToDateTime(x.Cells[3].Value) == currLoopDate).ToList();
                if (exist.Count == 0)
                {
                    var row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = currLoopDate.ToShortDateString() });
                    dgvMissingDates.Rows.Add(row);
                }
                currLoopDate = currLoopDate.Date.AddDays(1);
            }
        }

        private void GetMinAndMaxDate()
        {
            int index = 0;
            foreach (DataGridViewRow item in rowCollection)
            {
                if (index == 0)
                {
                    minDate = item.Cells[3].Value.ToString();
                    maxDate = item.Cells[3].Value.ToString();

                    lblDateFrom.Text = minDate;
                    lblDateTo.Text = maxDate;
                    index++;
                    continue;
                }
                else
                {
                    if (Convert.ToDateTime(minDate) > Convert.ToDateTime(item.Cells[3].Value))
                    {
                        lblDateFrom.Text = item.Cells[3].Value.ToString();
                    }

                    if (Convert.ToDateTime(maxDate) < Convert.ToDateTime(item.Cells[3].Value))
                    {
                        lblDateTo.Text = item.Cells[3].Value.ToString();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDateFrom_Click(object sender, EventArgs e)
        {

        }

        private void lblDateTo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            var cashOut = GenerateHistory();
            var success = presenter.CashOutSLP(rowCollection, chkApply.Checked, scholar.ScholarId, cashOut);
            if (success)
            {
                cashOut.SLPBalance = presenter.GetBalanceSLP(scholar.ScholarId);
                MessageBox.Show("Cash out successful!");
                if (chkExcel.Checked)
                {
                    var allRewards = CheckRewards();
                    var excel = new ExcelGenerator(r, scholar, allRewards, true, cashOut);
                    excel.LoadExcel();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Something went wrong during processing. Please check the logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable CheckRewards()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SLP Amount");
            dt.Columns.Add("Date Acquired");
            dt.Columns.Add("Reason");

            if (chkSLPCashOut.Checked || chkApply.Checked)
            {
                if (dgvOthers.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvOthers.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[2].Value))
                            dt.Rows.Add(row.Cells[1].Value, DateTime.Now.Date.ToShortDateString(), row.Cells[0].Value);
                    }
                }

                if (dgvBonus.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvBonus.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[2].Value))
                            dt.Rows.Add(row.Cells[1].Value, DateTime.Now.Date.ToShortDateString(), row.Cells[0].Value);
                    }
                }

                if (dgvPenalty.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvBonus.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[2].Value))
                            dt.Rows.Add(row.Cells[1].Value, DateTime.Now.Date.ToShortDateString(), row.Cells[0].Value);
                    }
                }
            }


            return dt;
        }

        private CashOut GenerateHistory()
        {
            var cashOut = new CashOut();
            cashOut.ScholarId = scholar.ScholarId;
            cashOut.TotalSLP = Convert.ToInt32(lblTotalSLP.Text);
            cashOut.ScholarSLP = Convert.ToDecimal(lblScholarSLP.Text);

            if (chkApply.Checked || chkSLPCashOut.Checked)
            {
                cashOut.ExtraSLP = Convert.ToInt32(lblAdjSLP.Text);
            }
           
            cashOut.CashOutDate = DateTime.Now.ToShortDateString();
            cashOut.SLPValue = Convert.ToDecimal(lblSLPValue.Text.Substring(lblSLPValue.Text.IndexOf("Php ") + 4));
            cashOut.AmountReceived = Convert.ToDecimal(lblConvert.Text.Substring(lblConvert.Text.IndexOf("Php ") + 4));
            cashOut.IsSlpCashOut = chkSLPCashOut.Checked;

            // if cash, automatic applied
            if (Convert.ToInt32(lblAdjSLP.Text) == 0 || (!chkSLPCashOut.Checked))
                cashOut.IsExtraSLPApplied = true;
            else
                cashOut.IsExtraSLPApplied = false;

            return cashOut;
        }

        private void chkApply_CheckedChanged(object sender, EventArgs e)
        {
            LoadDetails(chkApply.Checked);
        }

        private async void btnSLPLatest_Click(object sender, EventArgs e)
        {
            slp = await SLPValue.GetSLPValue();
            if (slp != null)
            {
                decimal php = Math.Round(slp.market_data.current_price.php, 3);
                lblSLPValue.Text = "SLP Value: Php " + php.ToString();

                decimal amt = Convert.ToDecimal(lblScholarSLP.Text) * php;
                lblConvert.Text = "Scholar Receives: Php " + string.Format("{0:#.00}", Convert.ToDecimal(amt));
            }
        }

        private async void frmCashOut_Load(object sender, EventArgs e)
        {
            if (chkSLPCashOut.Checked)
                lblConvert.Text = "Scholar Receives: Php 0.00";
            else
            {
                slp = await SLPValue.GetSLPValue();
                if (slp != null)
                {
                    php = Math.Round(slp.market_data.current_price.php, 3);
                    lblSLPValue.Text = "SLP Value: Php " + php.ToString();

                    amt = Convert.ToDecimal(lblScholarSLP.Text) * php;
                    lblConvert.Text = "Scholar Receives: Php " + string.Format("{0:#.00}", Convert.ToDecimal(amt));
                }
            }
            
            //chkSLPCashOut.Checked = this.scholar.IsSLPCashout;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row;
            // determine checkbox status
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                if (tbExtras.SelectedTab == tbExtras.TabPages["tbBonus"])
                {
                    dgvBonus.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    row = dgvBonus.Rows[e.RowIndex];
                }
                else if (tbExtras.SelectedTab == tbExtras.TabPages["tbPenalty"])
                {
                    dgvPenalty.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    row = dgvPenalty.Rows[e.RowIndex];
                }
                else
                {
                    dgvOthers.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    row = dgvOthers.Rows[e.RowIndex];
                }

                // check value 
                if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    lblAdjSLP.Text = (Convert.ToInt32(lblAdjSLP.Text) + Convert.ToInt32(row.Cells[1].Value.ToString())).ToString();
                    reward += Convert.ToInt32(row.Cells[1].Value.ToString());
                }
                else
                {
                    lblAdjSLP.Text = (Convert.ToInt32(lblAdjSLP.Text) - Convert.ToInt32(row.Cells[1].Value.ToString())).ToString();
                    reward -= Convert.ToInt32(row.Cells[1].Value.ToString());
                }

                if (chkApply.Checked)
                {
                    lblTotalSLP.Text = (Convert.ToInt32(origSLP) + Convert.ToInt32(lblAdjSLP.Text)).ToString();
                }
            }
        }

        private void chkSLPCashOut_CheckedChanged(object sender, EventArgs e)
        {
            LoadDetails(chkApply.Checked);
            btnSLPLatest.Enabled = !chkSLPCashOut.Checked;
            chkApply.Checked = chkSLPCashOut.Checked ? false : chkApply.Checked;
            chkApply.Enabled = !chkSLPCashOut.Checked;
        }
    }
}
