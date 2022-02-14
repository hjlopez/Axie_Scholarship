using Axie_Scholarship.API;
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
    public partial class frmAddOrSubtractSLP : Form
    {
        ExtraSLP extraSLP = null;
        ExtrasPresenter presenter;
        ExtraSLPViewModel vm;

        long scholarId = 0;
        public frmAddOrSubtractSLP(long scholarId)
        {
            InitializeComponent();
            this.scholarId = scholarId;

            extraSLP = new ExtraSLP();
            presenter = new ExtrasPresenter();
            vm = new ExtraSLPViewModel();
            this.HelpButtonClicked += frmAddOrSubtractSLP_HelpButtonClicked;

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
            extraSLP.DateAdded = DateTime.Now.ToShortDateString();
            extraSLP.Reason = txtReason.Text;
            extraSLP.ScholarId = scholarId;
            extraSLP.IsApplied = false;

            if (rbBonus.Checked)
            {
                extraSLP.SLPValue = Convert.ToInt32(txtBonus.Text);
            }
            else
            {
                extraSLP.SLPValue = Convert.ToInt32("-" + txtBonus.Text);
            }
            presenter.InsertScholarExtras(extraSLP);
            Reload();
        }

        private void Reload()
        {
            GenerateParameters();
            LoadData();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
