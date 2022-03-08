using Axie_Scholarship.Presenters;
using Axie_Scholarship.Views.Accomplishments;
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
    public partial class frmAccomplishments : Form
    {
        AccomplishmentPresenter<Models.Accomplishments> presenter = null;
        public frmAccomplishments()
        {
            InitializeComponent();
            presenter = new AccomplishmentPresenter<Models.Accomplishments>("0");

            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmAddAccomplishment();
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            dgvBonus.Rows.Clear();
            dgvDeductions.Rows.Clear();
            var dt = presenter.LoadData(null);
            var reward = "";
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToBoolean(row["IsPercent"]))
                    {
                        reward = (Convert.ToInt32(Convert.ToDecimal(row["Reward"]) * 100)).ToString() + "% of total SLP earned";
                    }
                    else
                    {
                        reward = Convert.ToInt32(row["Reward"]).ToString() + " SLP";
                    }

                    if (!Convert.ToBoolean(row["IsPenalty"]))
                    {
                        dgvBonus.Rows.Add(row["Id"], row["Name"], row["Description"], reward);
                    }
                    else
                    {
                        dgvDeductions.Rows.Add(row["Id"], row["Name"], row["Description"], reward);
                    }
                }
            }
            
        }
    }
}
