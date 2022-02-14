using Axie_Scholarship.DataAccess;
using Axie_Scholarship.Logs;
using Axie_Scholarship.Models;
using Axie_Scholarship.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.Presenters
{
    public class ExtrasPresenter
    {
        readonly DataAccessLayer dal;
        public ExtrasPresenter()
        {
            dal = new DataAccessLayer();
        }

        public bool InsertScholarExtras(ExtraSLP extraSLP)
        {
            try
            {
                var result = dal.ExecuteDataTable("usp_ins_extras",
                                dal.MakeInputParameters("SCHOLARID", extraSLP.ScholarId),
                                dal.MakeInputParameters("SLPVALUE", extraSLP.SLPValue),
                                dal.MakeInputParameters("REASON", extraSLP.Reason),
                                dal.MakeInputParameters("DATEADDED", extraSLP.DateAdded),
                                dal.MakeInputParameters("ISAPPLIED", extraSLP.IsApplied));

                MessageBox.Show("Successful entry!");
                return true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                MessageBox.Show("Something went wrong while saving. Please check the logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable LoadData(ExtraSLPViewModel extraSLP)
        {
            try
            {
                var dt = dal.ExecuteDataTable("usp_get_extras_scholar",
                                dal.MakeInputParameters("SCHOLARID", extraSLP.ScholarId),
                                dal.MakeInputParameters("STARTDATE", extraSLP.StartDate),
                                dal.MakeInputParameters("ENDDATE", extraSLP.EndDate));

                return dt;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                MessageBox.Show("Something went wrong while loading the data. Please check the logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
