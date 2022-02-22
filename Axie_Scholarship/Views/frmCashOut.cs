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
        string minDate = "";
        string maxDate = "";
        string origSLP = "";
        public frmCashOut(List<DataGridViewRow> rows, DataGridViewSelectedRowCollection r2, Scholar scholar)
        {
            InitializeComponent();
            rowCollection = rows;
            this.scholar = scholar;
            this.r = r2;
            presenter = new ScholarSLPPresenter<ScholarDetailViewModel>();
            GetMinAndMaxDate();
            LoadDetails();
            DetermineMissingDates();
            if (lblAdjSLP.Text == "0") chkApply.Enabled = false; 
            else chkApply.Enabled = true;
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
            
            lblScholarSLP.Text = (Convert.ToInt32(lblTotalSLP.Text) * (Convert.ToDecimal(share) / 100)).ToString();

            lblAdjSLP.Text = presenter.GetScholarExtrasById(scholar.ScholarId).ToString();

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
                MessageBox.Show("Cash out successful!");
                if (chkExcel.Checked)
                {
                    var excel = new ExcelGenerator(r, scholar, true, cashOut);
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

        private CashOut GenerateHistory()
        {
            var cashOut = new CashOut();
            cashOut.ScholarId = scholar.ScholarId;
            cashOut.TotalSLP = Convert.ToInt32(lblTotalSLP.Text);
            cashOut.ScholarSLP = Convert.ToDecimal(lblScholarSLP.Text);

            if (chkApply.Checked)
            {
                cashOut.ExtraSLP = Convert.ToInt32(lblAdjSLP.Text);
            }
           
            cashOut.CashOutDate = DateTime.Now.ToShortDateString();
            cashOut.SLPValue = Convert.ToDecimal(lblSLPValue.Text.Substring(lblSLPValue.Text.IndexOf("Php ") + 4));
            cashOut.AmountReceived = Convert.ToDecimal(lblConvert.Text.Substring(lblConvert.Text.IndexOf("Php ")+4));

            return cashOut;
        }

        private void chkApply_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApply.Checked)
            {
                LoadDetails(true);
            }
            else
            {
                LoadDetails(false);
            }
        }

        private async void btnSLPLatest_Click(object sender, EventArgs e)
        {
            var slp = await SLPValue.GetSLPValue();
            decimal php = Math.Round(slp.market_data.current_price.php, 3);
            lblSLPValue.Text = "SLP Value: Php " + php.ToString();

            decimal amt = Convert.ToDecimal(lblScholarSLP.Text) * php;
            lblConvert.Text = "Scholar Receives: Php " + string.Format("{0:#.00}", Convert.ToDecimal(amt));
        }

        private async void frmCashOut_Load(object sender, EventArgs e)
        {
            var slp = await SLPValue.GetSLPValue();
            decimal php = Math.Round(slp.market_data.current_price.php, 3);
            lblSLPValue.Text = "SLP Value: Php " + php.ToString();

            decimal amt = Convert.ToDecimal(lblScholarSLP.Text) * php;
            lblConvert.Text = "Scholar Receives: Php " + string.Format("{0:#.00}", Convert.ToDecimal(amt));
        }
    }
}
