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
    public partial class frmAddOrSubtractSLP : Form
    {
        ExtraSLP extraSLP = null;
        ExtrasPresenter presenter;

        long scholarId = 0;
        public frmAddOrSubtractSLP(long scholarId)
        {
            InitializeComponent();
            this.scholarId = scholarId;

            extraSLP = new ExtraSLP();
            presenter = new ExtrasPresenter();
            this.HelpButtonClicked += frmAddOrSubtractSLP_HelpButtonClicked;
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
        }
    }
}
