using Axie_Scholarship.DataAccess;
using Axie_Scholarship.Helpers;
using Axie_Scholarship.Logs;
using Axie_Scholarship.Models;
using Axie_Scholarship.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.Presenters
{
    public class ScholarSLPPresenter
    {
        DataAccessLayer dal;
        public ScholarSLPPresenter()
        {
            dal = new DataAccessLayer();
        }

        public DataTable LoadDataGrid(ScholarDetailViewModel vm)
        {
            try
            {
                var dt = dal.ExecuteDataTable("usp_get_scholar_slp", 
                                                dal.MakeInputParameters("SCHOLARID", vm.ScholarId),
                                                dal.MakeInputParameters("STARTDATE", vm.StartDate),
                                                dal.MakeInputParameters("ENDDATE", vm.EndDate),
                                                dal.MakeInputParameters("CASHOUTTYPE", vm.CashOutType));
                return dt;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }

        public string ComputeEarnedSLP(string start, string end)
        {
            try
            {
                if (!ExpressionsHelper.NumbersOnly(start) || !ExpressionsHelper.NumbersOnly(end)) return "0";
                int earn = Convert.ToInt32(end) - Convert.ToInt32(start);
                return earn.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return "0";
            }
        }

        public bool SaveEntry(ScholarDetails scholarDetails)
        {
            try
            {
                var result = dal.ExecuteDataTable("usp_insert_slp_entry",
                                    dal.MakeInputParameters("SCHOLARID", scholarDetails.ScholarId),
                                    dal.MakeInputParameters("SLPSTART", scholarDetails.SLPStart),
                                    dal.MakeInputParameters("SLPEND", scholarDetails.SLPEnd),
                                    dal.MakeInputParameters("SLPEARNED", scholarDetails.SLPEarnedToday),
                                    dal.MakeInputParameters("DATEEARNED", scholarDetails.DateEarned),
                                    dal.MakeInputParameters("ISCASHEDOUT", scholarDetails.IsCashedOut));

                if (result != null)
                {
                    var errMessage = result.Rows[0]["ErrorMessage"].ToString();
                    if (errMessage.ToUpper().Contains("UNIQUE"))
                    {
                        MessageBox.Show("There is already an existing entry with the same date! Please check your inputs again.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                MessageBox.Show("Successfully saved!");
                return true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                MessageBox.Show("Something went wrong while saving. Please check the logs.");
                return false;
            }
        }

        public bool ComposeDeleteEntry(DataGridViewSelectedRowCollection rows)
        {
            try
            {
                ScholarDetails scholarDetail = null;
                var detailList = new List<ScholarDetails>();


                foreach (DataGridViewRow item in rows)
                {
                    scholarDetail = new ScholarDetails();
                    scholarDetail.ScholarDetailId = Convert.ToInt64(item.Cells[0].Value);
                    detailList.Add(scholarDetail);
                }

                return DeleteSLPEntries(detailList);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }
        }

        public bool DeleteSLPEntries(List<ScholarDetails> list)
        {
            try
            {
                foreach (var item in list)
                {
                    dal.ExecuteDataTable("usp_delete_slp_entry", dal.MakeInputParameters("SCHOLARDETAILID", item.ScholarDetailId));
                }
                
                return true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }
        }

        public bool CashOutSLP(List<DataGridViewRow> rows)
        {
            try
            {

                foreach (DataGridViewRow item in rows)
                {
                    dal.ExecuteDataTable("usp_cashout_scholar_slp", dal.MakeInputParameters("SCHOLARDETAILID", Convert.ToInt64(item.Cells[0].Value)));
                }

                return true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }
        }

        public int ComputeTotalSLP(List<DataGridViewRow> rows)
        {
            int total = 0;
            try
            {
                foreach (DataGridViewRow item in rows)
                {
                    total += Convert.ToInt32(item.Cells[2].Value);
                }
                return total;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return 0;
            }
        }
    }
}
