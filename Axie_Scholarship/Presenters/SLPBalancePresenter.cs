using Axie_Scholarship.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axie_Scholarship.ViewModels;
using Axie_Scholarship.Logs;
using Axie_Scholarship.DataAccess;

namespace Axie_Scholarship.Presenters
{
    public class SLPBalancePresenter<T> : IData<T> where T : ViewModels.SLPBalanceViewModel
    {
        DataAccessLayer dal;
        public SLPBalancePresenter()
        {
            dal = new DataAccessLayer();
        }

        public bool Delete(T model)
        {
            throw new NotImplementedException();
        }

        public bool Insert(T model)
        {
            throw new NotImplementedException();
        }

        public DataTable LoadData(T model)
        {
            try
            {
                return dal.ExecuteDataTable("usp_get_scholar_cashout_not_applied",
                                            dal.MakeInputParameters("SCHOLARID", model.ScholarId));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }

        public bool Update(T model)
        {
            try
            {
                if (model.IsEarnedCashout)
                {
                    for (int i = 0; i < model.EarnCashOuts.Count; i++)
                    {
                        dal.ExecuteDataTable("usp_upd_scholar_earned_cashout", dal.MakeInputParameters("CASHOUTID", model.EarnCashOuts[i].CashOutId));
                    }
                    
                }
                else
                {
                    for (int i = 0; i < model.BonusCashOuts.Count; i++)
                    {
                        dal.ExecuteDataTable("usp_upd_scholar_bonus_cashout", dal.MakeInputParameters("CASHOUTID", model.BonusCashOuts[i].CashOutId));
                    }
                }
                
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
