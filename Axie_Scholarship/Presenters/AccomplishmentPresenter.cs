using Axie_Scholarship.Interface;
using Axie_Scholarship.Logs;
using Axie_Scholarship.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axie_Scholarship.Models;
using Axie_Scholarship.Constants;
using Axie_Scholarship.DataAccess;
using System.Windows.Forms;

namespace Axie_Scholarship.Presenters
{
    public class AccomplishmentPresenter<T> : IAccomplishment, IData<T> where T : Models.Accomplishments
    {
        DataAccessLayer dal;
        string type = "";
        string finalDescription = "";
        public AccomplishmentPresenter(string type)
        {
            dal = new DataAccessLayer();
            this.type = type;
        }

        public bool Delete(T model)
        {
            throw new NotImplementedException();
        }

        public string GenerateDescription(AccomplishmentViewModel vm)
        {
            finalDescription = "";
            try
            {
                if (type == "PVPBonus")
                {
                    GenerateStartDescription(true, vm.Record.IsPercent, vm.Record.Reward);
                    switch (vm.Record.Type)
                    {
                        case 1:
                            finalDescription = finalDescription + DescriptionConstants.descriptionOnceOrCustom;
                            if (vm.Record.Wins > 0 && vm.Record.Loss == 0 && vm.Record.Draw == 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins) + DescriptionConstants.once;
                            }
                            else if (vm.Record.Wins == 0 && vm.Record.Loss > 0 && vm.Record.Draw == 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.loss, vm.Record.Loss) + DescriptionConstants.once;
                            }
                            else if (vm.Record.Wins == 0 && vm.Record.Loss == 0 && vm.Record.Draw > 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.draw, vm.Record.Draw) + DescriptionConstants.once;
                            }
                            else if (vm.Record.Wins > 0 && vm.Record.Loss > 0 && vm.Record.Draw == 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins)
                                    + DescriptionConstants.and + string.Format(DescriptionConstants.loss, vm.Record.Loss) + DescriptionConstants.once;
                            }
                            else if (vm.Record.Wins == 0 && vm.Record.Loss > 0 && vm.Record.Draw > 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.loss, vm.Record.Loss)
                                    + DescriptionConstants.and + string.Format(DescriptionConstants.draw, vm.Record.Draw) + DescriptionConstants.once;
                            }
                            else // all has values
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins) + ", " 
                                    + string.Format(DescriptionConstants.loss, vm.Record.Loss)
                                    + DescriptionConstants.and + string.Format(DescriptionConstants.draw, vm.Record.Draw) + DescriptionConstants.once;
                            }

                            break;
                        case 2:
                            finalDescription = finalDescription + DescriptionConstants.descriptionOnceOrCustom;
                            if (vm.Record.Wins > 0 && vm.Record.Loss == 0 && vm.Record.Draw == 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins) 
                                    + string.Format(DescriptionConstants.custom, vm.Record.Frequency);
                            }
                            else if (vm.Record.Wins == 0 && vm.Record.Loss > 0 && vm.Record.Draw == 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.loss, vm.Record.Loss) 
                                    + string.Format(DescriptionConstants.custom, vm.Record.Frequency);
                            }
                            else if (vm.Record.Wins == 0 && vm.Record.Loss == 0 && vm.Record.Draw > 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.draw, vm.Record.Draw) 
                                    + string.Format(DescriptionConstants.custom, vm.Record.Frequency);
                            }
                            else if (vm.Record.Wins > 0 && vm.Record.Loss > 0 && vm.Record.Draw == 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins)
                                    + DescriptionConstants.and + string.Format(DescriptionConstants.loss, vm.Record.Loss) + string.Format(DescriptionConstants.custom, vm.Record.Frequency);
                            }
                            else if (vm.Record.Wins == 0 && vm.Record.Loss > 0 && vm.Record.Draw > 0)
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.loss, vm.Record.Loss)
                                    + DescriptionConstants.and + string.Format(DescriptionConstants.draw, vm.Record.Draw) + string.Format(DescriptionConstants.custom, vm.Record.Frequency);
                            }
                            else // all has values
                            {
                                finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins) + ", "
                                    + string.Format(DescriptionConstants.loss, vm.Record.Loss)
                                    + DescriptionConstants.and + string.Format(DescriptionConstants.draw, vm.Record.Draw) + string.Format(DescriptionConstants.custom, vm.Record.Frequency);
                            }
                            break;
                        case 3:
                            if (vm.Record.HasWinningPercentage)
                            {
                                finalDescription = finalDescription + DescriptionConstants.descriptionOnceOrCustom + DescriptionConstants.winningRecord;
                            }
                            else
                            {
                                finalDescription = finalDescription + DescriptionConstants.descriptionTotal;
                                if (vm.Record.Wins > 0 && vm.Record.Loss == 0 && vm.Record.Draw == 0)
                                {
                                    finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins) + DescriptionConstants.total;
                                }
                                else if (vm.Record.Wins == 0 && vm.Record.Loss > 0 && vm.Record.Draw == 0)
                                {
                                    finalDescription = finalDescription + string.Format(DescriptionConstants.loss, vm.Record.Loss) + DescriptionConstants.total;
                                }
                                else if (vm.Record.Wins == 0 && vm.Record.Loss == 0 && vm.Record.Draw > 0)
                                {
                                    finalDescription = finalDescription + string.Format(DescriptionConstants.draw, vm.Record.Draw) + DescriptionConstants.total;
                                }
                                else if (vm.Record.Wins > 0 && vm.Record.Loss > 0 && vm.Record.Draw == 0)
                                {
                                    finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins)
                                        + DescriptionConstants.and + string.Format(DescriptionConstants.loss, vm.Record.Loss) + DescriptionConstants.total;
                                }
                                else if (vm.Record.Wins == 0 && vm.Record.Loss > 0 && vm.Record.Draw > 0)
                                {
                                    finalDescription = finalDescription + string.Format(DescriptionConstants.loss, vm.Record.Loss)
                                        + DescriptionConstants.and + string.Format(DescriptionConstants.draw, vm.Record.Draw) + DescriptionConstants.total;
                                }
                                else // all has values
                                {
                                    finalDescription = finalDescription + string.Format(DescriptionConstants.win, vm.Record.Wins) + ", "
                                        + string.Format(DescriptionConstants.loss, vm.Record.Loss)
                                        + DescriptionConstants.and + string.Format(DescriptionConstants.draw, vm.Record.Draw) + DescriptionConstants.total;
                                }
                            }
                            
                            break;
                        default:
                            break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return "";
            }

            return finalDescription;
        }

        public void GenerateStartDescription(bool isBonus, bool isPercent, decimal value)
        {
            try
            {
                
                if (isBonus)
                {
                    finalDescription = DescriptionConstants.openingDescriptionBonus;
                }
                else
                {
                    finalDescription = DescriptionConstants.openingDescriptionPenalty;
                }

                if (isPercent)
                {
                    finalDescription = finalDescription + string.Format(DescriptionConstants.percentSLP, value);
                }
                else
                {
                    finalDescription = finalDescription + string.Format(DescriptionConstants.exactSLP, value);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }

        }

        public bool Insert(T model)
        {
            try
            {
                dal.ExecuteDataTable("usp_ins_accomplishments",
                    dal.MakeInputParameters("NAME", model.Name),
                    dal.MakeInputParameters("DESCRIPTION", model.Description),
                    dal.MakeInputParameters("REWARD", model.Reward),
                    dal.MakeInputParameters("ISPERCENT", model.IsPercent),
                    dal.MakeInputParameters("ISPENALTY", model.IsPenalty));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }
            return true;
        }

        public DataTable LoadData(T model)
        {
            throw new NotImplementedException();
        }

        public bool Update(T model)
        {
            throw new NotImplementedException();
        }

        public bool Validate(AccomplishmentViewModel vm)
        {
            try
            {
                if (vm.Record.Type == 3)
                {
                    if (!vm.Record.HasWinningPercentage && ((vm.Record.Wins == 0 && vm.Record.Loss == 0 && vm.Record.Draw == 0) || vm.Record.Reward == 0))
                    {
                        return false;
                    }
                }
                else
                {
                    if ((vm.Record.Wins == 0 && vm.Record.Loss == 0 && vm.Record.Draw == 0) || vm.Record.Reward == 0) return false;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }

            return true;
        }

        public bool IsAccomplished(string description, List<DataGridViewRow> rows)
        {
            List<string> criteria = null;
            bool gotReward = false;
            var p = new AccomplishmentCheckerPresenter();
            try
            {
                // get checker
                //foreach (string item in DescriptionConstants.checker)
                //{
                //    if (description.Contains(item))
                //    {
                //        criteria.Add(item);
                //    }
                //}

                //if (criteria == null) return false;

                // start checking
                // one time checker
                if (description.Contains("win") && description.Contains("once"))
                {
                    if (p.CheckWinsOnce(rows, "15")) return true;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }

            return gotReward;
        }
        
    }
}
