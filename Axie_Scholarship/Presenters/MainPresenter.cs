using Axie_Scholarship.DataAccess;
using Axie_Scholarship.Logs;
using Axie_Scholarship.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.Presenters
{
    public class MainPresenter
    {
        DataAccessLayer dal;
        public MainPresenter()
        {
            dal = new DataAccessLayer();
        }
        public DataTable LoadScholars()
        {
            try
            {
                var dt = dal.ExecuteDataTable("usp_get_scholars");
                return dt;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
            
        }

        public Scholar GetScholarDetails(object rowView)
        {
            try
            {
                var srv = rowView as DataRowView;
                return new Scholar
                {
                    ScholarId = Convert.ToInt64(srv["ScholarId"]),
                    ScholarName = srv["ScholarName"].ToString(),
                    DateAdded = srv["DateStarted"].ToString(),
                    IsActive = Convert.ToBoolean(srv["IsActive"]),
                    CutOffDays = Convert.ToInt32(srv["CutOff"]),
                    ScholarCut = Convert.ToInt32(srv["ScholarCut"]),
                    IsSLPCashout = Convert.ToBoolean(srv["IsSLPCashout"])
                };
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }
    }
}
