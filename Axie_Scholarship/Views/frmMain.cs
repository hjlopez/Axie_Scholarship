using Axie_Scholarship.Connection;
using Axie_Scholarship.Models;
using Axie_Scholarship.Presenters;
using Axie_Scholarship.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship
{
    public partial class frmMain : Form
    {
        MainPresenter mainPresenter;
        Scholar scholar;
        public frmMain()
        {
            mainPresenter = new MainPresenter();
            scholar = new Scholar();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var add = new frmAddScholar();
            add.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvScholarList.DataSource = mainPresenter.LoadScholars();
        }

        private void btnViewScholar_Click(object sender, EventArgs e)
        {
            if (dgvScholarList.RowCount > 0)
            {
                scholar = mainPresenter.GetScholarDetails(dgvScholarList.CurrentRow.DataBoundItem);
                var frm = new frmScholarView(scholar);
                frm.ShowDialog();
            }
        }

        private void btnAccomp_Click(object sender, EventArgs e)
        {
            var frm = new frmAccomplishments();
            frm.ShowDialog();
        }
    }
}
