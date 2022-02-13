using Axie_Scholarship.Models;
using Axie_Scholarship.Presenters;
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
        ScholarSLPPresenter presenter;
        string minDate = "";
        string maxDate = "";
        string origSLP = "";
        public frmCashOut(List<DataGridViewRow> rows, Scholar scholar)
        {
            InitializeComponent();
            rowCollection = rows;
            this.scholar = scholar;
            presenter = new ScholarSLPPresenter();
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
            var success = presenter.CashOutSLP(rowCollection);

            if (success)
            {
                MessageBox.Show("Cash out successful!");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Something went wrong during processing. Please check the logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
