using Axie_Scholarship.Helpers;
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
    public partial class frmAddSLPEntry : Form
    {
        ScholarDetails scholarDetails;
        ScholarSLPPresenter presenter;
        long scholarId;
        public frmAddSLPEntry(long scholarId)
        {
            InitializeComponent();
            this.scholarId = scholarId;
            this.HelpButtonClicked += frmAddSLPEntry_HelpButtonClicked;
            scholarDetails = new ScholarDetails();
            presenter = new ScholarSLPPresenter();
            txtSLPEarned.KeyPress += new KeyPressEventHandler(txtSLPEarned_KeyPress);
            txtSLPEarned.TextChanged += new EventHandler(txtSLPEarned_TextChanged);
            txtSLPStart.TextChanged += new EventHandler(txtSLPStart_TextChanged);
            txtSLPEnd.TextChanged += new EventHandler(txtSLPEnd_TextChanged);
        }

        private void txtSLPEarned_TextChanged(object sender, EventArgs e)
        {
            if (txtSLPEarned.Text == string.Empty || !ExpressionsHelper.NumbersOnly(txtSLPEarned.Text)) txtSLPEarned.Text = "0";
        }

        private void txtSLPEnd_TextChanged(object sender, EventArgs e)
        {
            if (!ExpressionsHelper.NumbersOnly(txtSLPEnd.Text)) txtSLPEnd.Text = "0";
            txtSLPEarned.Text = presenter.ComputeEarnedSLP(ConversionHelper.ReturnZeroIfNull(txtSLPStart.Text), ConversionHelper.ReturnZeroIfNull(txtSLPEnd.Text));
        }

        private void txtSLPStart_TextChanged(object sender, EventArgs e)
        {
            if (!ExpressionsHelper.NumbersOnly(txtSLPStart.Text)) txtSLPStart.Text = "0";
            txtSLPEarned.Text = presenter.ComputeEarnedSLP(ConversionHelper.ReturnZeroIfNull(txtSLPStart.Text), ConversionHelper.ReturnZeroIfNull(txtSLPEnd.Text));
        }

        private void txtSLPEarned_KeyPress(object sender, EventArgs e)
        {
            txtSLPEnd.Text = "";
            txtSLPStart.Text = "";
        }

        private void frmAddSLPEntry_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("If you want to input the start and end SLP for the day, it will automatically compute the earned SLP. You can also input manually the earned SLP and it will clear the values for the start and end SLP field. Start and End SLP fields are optional.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var success = false;
            scholarDetails.DateEarned = dtpEarned.Value.ToString("yyyyMMdd");
            scholarDetails.ScholarId = this.scholarId;
            scholarDetails.SLPStart = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtSLPStart.Text));
            scholarDetails.SLPEnd = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtSLPEnd.Text));
            scholarDetails.SLPEarnedToday = Convert.ToInt32(ConversionHelper.ReturnZeroIfNull(txtSLPEarned.Text));

            if (scholarDetails.SLPEarnedToday == 0)
            {
                DialogResult result = MessageBox.Show("SLP earned today is 0. Do you want to save this entry?", "Zero SLP", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    success = presenter.SaveEntry(scholarDetails);
                }
               
            }
            else
            {
                success = presenter.SaveEntry(scholarDetails);
            }

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
           
        }
    }
}
