using Axie_Scholarship.DataAccess;
using Axie_Scholarship.Interface;
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
    public class ExtrasPresenter<T> : IData<T> where T : ExtraSLPViewModel
    {
        readonly DataAccessLayer dal;
        public ExtrasPresenter()
        {
            dal = new DataAccessLayer();
        }

        public bool Insert(T extraSLP)
        {
            try
            {
                var result = dal.ExecuteDataTable("usp_ins_extras",
                                dal.MakeInputParameters("SCHOLARID", extraSLP.ExtraSLP.ScholarId),
                                dal.MakeInputParameters("SLPVALUE", extraSLP.ExtraSLP.SLPValue),
                                dal.MakeInputParameters("REASON", extraSLP.ExtraSLP.Reason),
                                dal.MakeInputParameters("DATEADDED", extraSLP.ExtraSLP.DateAdded),
                                dal.MakeInputParameters("ISAPPLIED", extraSLP.ExtraSLP.IsApplied));

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

        public bool Delete(T model)
        {
            try
            {
                foreach (long id in model.ExtrasIds)
                {
                    dal.ExecuteDataTable("usp_del_extras", dal.MakeInputParameters("ID", id));
                }

                return true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }
        }

        public DataTable LoadData(T extraSLP) 
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

        public bool Update(T model)
        {
            throw new NotImplementedException();
        }

        public List<long> ComposeDeleteEntry(DataGridViewSelectedRowCollection rows)
        {
            try
            {
                long id = 0;
                var scholarIds = new List<long>();


                foreach (DataGridViewRow item in rows)
                {
                    id = Convert.ToInt64(item.Cells[0].Value);
                    scholarIds.Add(id);
                }

                return scholarIds;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }
    }
}
