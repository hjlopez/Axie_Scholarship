using Axie_Scholarship.DataAccess;
using Axie_Scholarship.Logs;
using Axie_Scholarship.Models;
using System;
using System.Collections.Generic;
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
                return false;
            }
        }
    }
}
