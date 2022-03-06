using Axie_Scholarship.DataAccess;
using Axie_Scholarship.Helpers;
using Axie_Scholarship.Interface;
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
    public class ScholarSLPPresenter<T> : IData<T> where T : ScholarDetailViewModel
    {
        DataAccessLayer dal;
        public ScholarSLPPresenter()
        {
            dal = new DataAccessLayer();
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

        public List<ScholarDetails> ComposeDeleteEntry(DataGridViewSelectedRowCollection rows)
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

                return detailList;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }

        public bool CashOutSLP(List<DataGridViewRow> rows, bool isApplied, long scholarId, CashOut cashOut)
        {
            try
            {
                foreach (DataGridViewRow item in rows)
                {
                    dal.ExecuteDataTable("usp_cashout_scholar_slp", dal.MakeInputParameters("SCHOLARDETAILID", Convert.ToInt64(item.Cells[0].Value)));
                }

                // extras
                if (isApplied)
                {
                    dal.ExecuteDataTable("usp_upd_scholar_extras", dal.MakeInputParameters("SCHOLARID", scholarId));
                }

                // transact history
                dal.ExecuteDataTable("usp_ins_cashout_transaction",
                                dal.MakeInputParameters("SCHOLARID", cashOut.ScholarId),
                                dal.MakeInputParameters("TOTALSLP", cashOut.TotalSLP),
                                dal.MakeInputParameters("SCHOLARSLP", cashOut.ScholarSLP),
                                dal.MakeInputParameters("EXTRASLP", cashOut.ExtraSLP),
                                dal.MakeInputParameters("CASHOUTDATE", cashOut.CashOutDate),
                                dal.MakeInputParameters("SLPVALUE", cashOut.SLPValue),
                                dal.MakeInputParameters("AMOUNTRECEIVED", cashOut.AmountReceived));

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

        public int GetScholarExtrasById(long scholarId)
        {
            int slp = 0;
            try
            {
                var dt = dal.ExecuteDataTable("usp_get_extras_scholar_byId", dal.MakeInputParameters("SCHOLARID", scholarId));
                foreach (DataRow item in dt.Rows)
                {
                    slp += Convert.ToInt32(item["SLPValue"]);
                }
                return slp;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return 0;
            }
        }

        public DataTable LoadData(T vm)
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

        public bool Insert(T vm)
        {
            try
            {
                var result = dal.ExecuteDataTable("usp_chk_if_date_exists_for_scholar",
                                    dal.MakeInputParameters("SCHOLARID", vm.ScholarDetails.ScholarId),
                                    dal.MakeInputParameters("DATEEARNED", vm.ScholarDetails.DateEarned));

                if (result != null)
                {
                    MessageBox.Show("There is already an existing entry with the same date! Please check your inputs again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                dal.ExecuteDataTable("usp_insert_slp_entry",
                                    dal.MakeInputParameters("SCHOLARID", vm.ScholarDetails.ScholarId),
                                    dal.MakeInputParameters("SLPSTART", vm.ScholarDetails.SLPStart),
                                    dal.MakeInputParameters("SLPEND", vm.ScholarDetails.SLPEnd),
                                    dal.MakeInputParameters("SLPEARNED", vm.ScholarDetails.SLPEarnedToday),
                                    dal.MakeInputParameters("DATEEARNED", vm.ScholarDetails.DateEarned),
                                    dal.MakeInputParameters("ISCASHEDOUT", vm.ScholarDetails.IsCashedOut),
                                    dal.MakeInputParameters("WINS", vm.ScholarDetails.PVPWin),
                                    dal.MakeInputParameters("LOSE", vm.ScholarDetails.PVPLose),
                                    dal.MakeInputParameters("DRAWS", vm.ScholarDetails.PVPDraw),
                                    dal.MakeInputParameters("MMR", vm.ScholarDetails.CurrentMMR));

               
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

        public bool Delete(T model)
        {
            try
            {
                foreach (var item in model.ScholarDetailsList)
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

        public bool Update(T model)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAccomplishments()
        {
            DataTable dt = null;
            try
            {
                dt = dal.ExecuteDataTable("usp_get_accomplishments");
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }

            return dt;
        }
    }
}
