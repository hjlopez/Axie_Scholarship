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
    public partial class frmScholarView : Form
    {
        Scholar scholar;
        bool hasChange = false;
        bool onLoad = true;
        ScholarSLPPresenter presenter;
        ScholarDetailViewModel vm;
        DataTable dt;
        
        public frmScholarView(Scholar s)
        {
            scholar = new Scholar();
            presenter = new ScholarSLPPresenter();
            vm = new ScholarDetailViewModel();
            this.scholar = s;
            InitializeComponent();
            LoadValues();
            LoadFilters();
            LoadDataGrid();

            txtCutOff.LostFocus += new EventHandler(txtCutOff_LostFocus);
            txtScholarCut.LostFocus += new EventHandler(txtScholarCut_LostFocus);
        }
        
        private void LoadDataGrid()
        {
            CreateParameters();
            dt = presenter.LoadDataGrid(vm);
            dgvScholarDetails.DataSource = dt;
            if (dgvScholarDetails.Columns.Count > 0)
            {
                dgvScholarDetails.Columns[0].Visible = false;
                dgvScholarDetails.Columns[1].Visible = false;

                dgvScholarDetails.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvScholarDetails.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvScholarDetails.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvScholarDetails.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvScholarDetails.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvScholarDetails.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvScholarDetails.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            }
        }

        private void CreateParameters()
        {
            vm.ScholarId = scholar.ScholarId;
            vm.StartDate = dtpStart.Value.ToString("yyyyMMdd");
            vm.EndDate = dtpEnd.Value.ToString("yyyyMMdd");

            if (rbAll.Checked) vm.CashOutType = 2;
            else if (rbCashOut.Checked) vm.CashOutType = 1;
            else if (rbNotCashOut.Checked) vm.CashOutType = 0;
        }

        private void LoadValues()
        {
            lblScholarName.Text = scholar.ScholarName;
            txtCutOff.Text = scholar.CutOffDays.ToString();
            chkActive.Checked = scholar.IsActive;
            txtScholarCut.Text = scholar.ScholarCut.ToString();
        }

        private void frmScholarView_Load(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            CheckForChanges();
            EnableDisableSave();
        }

        private void EnableDisableSave()
        {
            if (!onLoad)
            {
                if (hasChange) btnSave.Enabled = true;
                else btnSave.Enabled = false;
            }
            else
            {
                onLoad = false;
                hasChange = false;
            }
        }

        private void CheckForChanges()
        {
            if (chkActive.Checked != scholar.IsActive || txtCutOff.Text != scholar.CutOffDays.ToString() || txtScholarCut.Text != scholar.ScholarCut.ToString())
            {
                hasChange = true;
            }
            else hasChange = false;
        }

        private void txtScholarCut_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtScholarCut.Text)) txtScholarCut.Text = scholar.ScholarCut.ToString();
        }

        private void txtCutOff_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCutOff.Text)) txtCutOff.Text = scholar.CutOffDays.ToString();
        }

        private void txtCutOff_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtCutOff.Text) && !ExpressionsHelper.NumbersOnly(txtCutOff.Text))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    txtCutOff.Text = txtCutOff.Text.Remove(txtCutOff.Text.Length - 1);
            //    return;
            //}
            CheckForChanges();
            EnableDisableSave();
        }

        private void txtScholarCut_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtScholarCut.Text) && !ExpressionsHelper.NumbersOnly(txtScholarCut.Text))
            {
                MessageBox.Show("Please enter only numbers.");
                txtScholarCut.Text = txtScholarCut.Text.Remove(txtScholarCut.Text.Length - 1);
                return;
            }
            CheckForChanges();
            EnableDisableSave();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmAddSLPEntry(scholar.ScholarId);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadDataGrid();
            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;
            int notCashOutCount = 0;
            int selectedCount = 0;

            var selectedRows = dgvScholarDetails.SelectedRows;

            foreach (DataGridViewRow item in selectedRows)
            {
                if (!Convert.ToBoolean(item.Cells[6].Value))
                {
                    notCashOutCount++;
                }
                selectedCount++;
            }

            if (notCashOutCount > 0)
            {
                var row = "";
                var are = "";
                if (notCashOutCount == 1)
                {
                    row = "row";
                    are = "is";
                }
                else
                {
                    row = "rows";
                    are = "are";
                }

                result = MessageBox.Show("You've selected "+ notCashOutCount + " " + row +" that "+ are +" not cashed out yet. Proceed with deletion?" , 
                                        "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Delete(selectedRows);   
                }
            }
            else if (selectedCount > 0)
            {
                result = MessageBox.Show("Confirm deletion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Delete(selectedRows);
                }
                 
            }
            
        }

        private void Delete(DataGridViewSelectedRowCollection rows)
        {
            if (presenter.ComposeDeleteEntry(rows))
            {
                MessageBox.Show("Successfully deleted!");
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Something went wrong during deletion. Please check logs.");
            }
        }

        private void LoadFilters()
        {
            LoadDateTime();
            SetRadioButton();
        }

        private void LoadDateTime()
        {
            // get previous month (and year if needed)
            var today = DateTime.Today;
            dtpStart.Value = DateTime.Today.AddDays(-(today.Day - 1));
            dtpEnd.Value = today;
        
        }

        private void SetRadioButton()
        {
            rbAll.Checked = true;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void rbCashOut_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbNotCashOut_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var s = dgvScholarDetails.SelectedRows;
            LoadDataGrid();
            chkSelectAll.Checked = false;
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            DialogResult ret = DialogResult.Yes;
            var selectedRows = dgvScholarDetails.SelectedRows;
            var rowsNotCashOut = selectedRows.Cast<DataGridViewRow>().Where(s => Convert.ToBoolean(s.Cells[6].Value) == false).ToList();
            if (selectedRows.Count > 0)
            {
                // all selected rows are already cashed out
                if (rowsNotCashOut.Count == 0)
                {
                    MessageBox.Show("All selected rows are already cashed out. Please check your selection.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rowsNotCashOut.Count != selectedRows.Count) // there are some selections that are already cashed out
                {
                    var result = MessageBox.Show("Some selected items are already cashed out. It will not be included in the next process. Proceed anyway?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        var frm = new frmCashOut(rowsNotCashOut, scholar);
                        ret = frm.ShowDialog();

                        
                    }
                }
                else
                {
                    var frm = new frmCashOut(rowsNotCashOut, scholar);
                    ret = frm.ShowDialog();
                }

                if (ret == DialogResult.OK)
                {
                    LoadDataGrid();
                }

            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var excelGenerator = new ExcelGenerator();
            excelGenerator.LoadExcel();
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            var frm = new frmAddOrSubtractSLP(scholar.ScholarId);
            frm.ShowDialog();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                foreach (DataGridViewRow row in dgvScholarDetails.Rows)
                {
                    if (!Convert.ToBoolean(row.Cells["Cash Out"].Value))
                    {
                        row.Selected = true;
                    }
                    
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvScholarDetails.Rows)
                {
                    row.Selected = false;
                }
            }
            
        }
    }
}
