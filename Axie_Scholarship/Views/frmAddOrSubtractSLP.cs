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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.Views
{
    public partial class frmAddOrSubtractSLP : Form
    {
        ExtraSLP extraSLP = null;
        ExtrasPresenter<ExtraSLPViewModel> presenter;
        ExtraSLPViewModel vm;

        long scholarId = 0;
        string value = "";
        public frmAddOrSubtractSLP(long scholarId)
        {
            InitializeComponent();
            this.scholarId = scholarId;

            extraSLP = new ExtraSLP();
            presenter = new ExtrasPresenter<ExtraSLPViewModel>();
            vm = new ExtraSLPViewModel();
            this.HelpButtonClicked += frmAddOrSubtractSLP_HelpButtonClicked;
            txtBonus.KeyPress += new KeyPressEventHandler(txtBonus_KeyPress);

            dtpStart.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpEnd.Value = DateTime.Now.Date;
            Reload();
        }

        private void frmAddOrSubtractSLP_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            string message1 = "You may input additional bonuses or penalties to the scholar in this form. ";
            string message2 = "When you cash out, you can choose if you want to apply the extras of the scholar or not.";
            MessageBox.Show(message1 + message2, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadData()
        {
            dgvList.DataSource = presenter.LoadData(vm);
            if (dgvList.DataSource != null)
            {
                dgvList.Columns[0].Visible = false;
                dgvList.Columns[1].Visible = false;

                dgvList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvList.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvList.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvList.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvList.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void GenerateParameters()
        {
            vm.ScholarId = scholarId;
            vm.StartDate = dtpStart.Value.ToShortDateString();
            vm.EndDate = dtpEnd.Value.ToShortDateString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vm.ExtraSLP = new ExtraSLP();
            vm.ExtraSLP.DateAdded = DateTime.Now.ToShortDateString();
            vm.ExtraSLP.Reason = txtReason.Text;
            vm.ExtraSLP.ScholarId = scholarId;
            vm.ExtraSLP.IsApplied = false;

            if (rbBonus.Checked)
            {
                vm.ExtraSLP.SLPValue = Convert.ToInt32(txtBonus.Text);
            }
            else
            {
                vm.ExtraSLP.SLPValue = Convert.ToInt32("-" + txtBonus.Text);
            }
            presenter.Insert(vm);
            Reload();
        }

        private void Reload()
        {
            GenerateParameters();
            LoadData();

            if (dgvList.Rows.Count == 0)
            {
                chkNotApplied.Enabled = false;
                chkSelectAll.Enabled = false;
            }
            else
            {
                chkNotApplied.Enabled = true;
                chkSelectAll.Enabled = true;
            }

            chkSelectAll.Checked = false;
            chkNotApplied.Checked = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;
            int notApplied = 0;
            int selectedCount = 0;

            var selectedRows = dgvList.SelectedRows;

            foreach (DataGridViewRow item in selectedRows)
            {
                if (!Convert.ToBoolean(item.Cells[5].Value))
                {
                    notApplied++;
                }
                selectedCount++;
            }

            if (notApplied > 0)
            {
                var row = "";
                var are = "";
                if (notApplied == 1)
                {
                    row = "row";
                    are = "is";
                }
                else
                {
                    row = "rows";
                    are = "are";
                }

                result = MessageBox.Show("You've selected " + notApplied + " " + row + " that " + are + " not applied yet. Proceed with deletion?",
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
            vm.ExtrasIds = presenter.ComposeDeleteEntry(rows);
            if (presenter.Delete(vm))
            {
                MessageBox.Show("Successful deletion!", "Extras SLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
            else
            {
                MessageBox.Show("Something went wrong while deleting! Please check the logs.", "Extras SLP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Enabled)
            {
                if (chkSelectAll.Checked)
                {
                    chkNotApplied.Checked = false;
                    SelectRows(true);
                }
                else
                {
                    dgvList.ClearSelection();
                }
            }
        }

        private void chkNotApplied_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotApplied.Enabled)
            {
                if (chkNotApplied.Checked)
                {
                    chkSelectAll.Checked = false;
                    SelectRows(false);
                }
                else
                {
                    dgvList.ClearSelection();
                }
            }
        }

        private void SelectRows(bool isAll = false)
        {
            dgvList.ClearSelection();

            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (!isAll)
                {
                    if (!Convert.ToBoolean(row.Cells["APPLIED?"].Value))
                    {
                        row.Selected = true;
                    }
                }
                else
                {
                    row.Selected = true;
                }
               
            }
        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            if (!ExpressionsHelper.NumbersOnly(txtBonus.Text))
            {
                MessageBox.Show("Numbers only!");
                txtBonus.Text = value;
            }

        }

        private void txtBonus_KeyPress(object sender, EventArgs e)
        {
            value = txtBonus.Text;
        }
    }
}
