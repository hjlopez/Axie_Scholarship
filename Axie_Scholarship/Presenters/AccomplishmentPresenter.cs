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
        AccomplishmentCheckerPresenter p = null;
        public AccomplishmentPresenter(string type)
        {
            dal = new DataAccessLayer();
            this.type = type;
            p = new AccomplishmentCheckerPresenter(); 
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
            bool gotReward = false;
            
            try
            {
                // start checking
                // one time checker
                #region PVPRecords
                #region OneTimeChecker
                if (description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // win
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.COnce))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CWin), 1, DescriptionConstants.CWin)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // lose
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.COnce))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CLose), 1, DescriptionConstants.CLose)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.COnce))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CDraw), 1, DescriptionConstants.CDraw)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // win and lose
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.COnce))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CWin), 1, DescriptionConstants.CWin) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CLose), 1, DescriptionConstants.CLose)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // win and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.COnce))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CWin), 1, DescriptionConstants.CWin) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CDraw), 1, DescriptionConstants.CDraw)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // lose and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.COnce))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CLose), 1, DescriptionConstants.CLose) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CDraw), 1, DescriptionConstants.CDraw)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // win, lose and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.COnce))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CWin), 1, DescriptionConstants.CWin) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CLose), 1, DescriptionConstants.CLose) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CDraw), 1, DescriptionConstants.CDraw)) return true;
                }
                #endregion

                // frequency checker
                #region FrequencyChecker
                if (description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // win
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTimesDuring))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CWin)
                        , GetTargetValue(description, DescriptionConstants.CTimesDuring), DescriptionConstants.CWin)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // lose
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTimesDuring))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CLose)
                        , GetTargetValue(description, DescriptionConstants.CTimesDuring), DescriptionConstants.CLose)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTimesDuring))
                {
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CDraw)
                        , GetTargetValue(description, DescriptionConstants.CTimesDuring), DescriptionConstants.CDraw)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // win and lose
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTimesDuring))
                {
                    var times = GetTargetValue(description, DescriptionConstants.CTimesDuring);
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CWin), times, DescriptionConstants.CWin) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CLose), times, DescriptionConstants.CLose)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // win and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTimesDuring))
                {
                    var times = GetTargetValue(description, DescriptionConstants.CTimesDuring);
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CWin), times, DescriptionConstants.CWin) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CDraw), times, DescriptionConstants.CDraw)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // lose and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTimesDuring))
                {
                    var times = GetTargetValue(description, DescriptionConstants.CTimesDuring);
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CLose), times, DescriptionConstants.CLose) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CDraw), times, DescriptionConstants.CDraw)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // win, lose and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTimesDuring))
                {
                    var times = GetTargetValue(description, DescriptionConstants.CTimesDuring);
                    if (p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CWin), times, DescriptionConstants.CWin) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CLose), times, DescriptionConstants.CLose) &&
                        p.CheckIndividualRecord(rows, GetTargetValue(description, DescriptionConstants.CDraw), times, DescriptionConstants.CDraw)) return true;
                }
                #endregion

                // total checker
                #region TotalChecker
                if (description.Contains(DescriptionConstants.CWinningRecord)) // total wins > total losses
                {
                    if (p.CheckWinLosePercentage(rows, true)) return true;
                }

                else if (description.Contains(DescriptionConstants.CLosingRecord)) // total wins < total losses
                {
                    if (p.CheckWinLosePercentage(rows, false)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // win
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTotal))
                {
                    if (p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CWin), DescriptionConstants.CWin)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // lose
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTotal))
                {
                    if (p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CLose), DescriptionConstants.CLose)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTotal))
                {
                    if (p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CDraw), DescriptionConstants.CDraw)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && description.Contains(DescriptionConstants.CLose) // win and lose
                    && !description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTotal))
                {
                    if (p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CWin), DescriptionConstants.CWin) &&
                        p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CLose), DescriptionConstants.CLose)) return true;
                }

                else if (description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // win and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTotal))
                {
                    if (p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CWin), DescriptionConstants.CWin) &&
                        p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CDraw), DescriptionConstants.CDraw)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // lose and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTotal))
                {
                    if (p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CLose), DescriptionConstants.CLose) &&
                        p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CDraw), DescriptionConstants.CDraw)) return true;
                }

                else if (!description.Contains(DescriptionConstants.CWin) && !description.Contains(DescriptionConstants.CLose) // win, lose and draw
                    && description.Contains(DescriptionConstants.CDraw) && description.Contains(DescriptionConstants.CTotal))
                {
                    if (p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CWin), DescriptionConstants.CWin) &&
                        p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CLose), DescriptionConstants.CLose) &&
                        p.CheckIndividualRecordTotal(rows, GetTargetValue(description, DescriptionConstants.CDraw), DescriptionConstants.CDraw)) return true;
                }
                #endregion
                #endregion


            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }

            return gotReward;
        }

        public int CheckForPenalties(List<DataGridViewRow> rows, int limit)
        {
            try
            {
                int count = p.CheckForPenalties(rows, limit);
                return count;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return -1;
            }
        }

        public int GetFrequency(string description)
        {
            int value = 0;
            int endIndex = 0;
            int startIndex = 0;
            bool doGet = false;
            try
            {
                // get index of keyword
                var a = description.IndexOf(DescriptionConstants.CLose);

                // go back until you reached the open parenthesis string
                var newDescription = description.Substring(0, a);
                for (int i = newDescription.Length - 1; i >= 0; i--)
                {
                    // since it's backwards, get closing parenthesis first and assign it as the end index
                    if (newDescription[i] == ')')
                    {
                        endIndex = i;
                        doGet = true;
                        continue;
                    }
                    else
                    {
                        if (doGet)
                        {
                            // check if open parenthesis and make it as start index
                            if (newDescription[i] == '(')
                            {
                                startIndex = i;
                                doGet = false;
                                break;
                            }
                        }
                    }
                }

                // get the target value
                // add 1 to start index to skip opening parenthesis
                // subtract 1 from end index to skip closing parenthesis
                value = Convert.ToInt32(newDescription.Substring(startIndex + 1, (endIndex - 1) - (startIndex)));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return 0;
            }
            return value;
        }

        public int GetTargetValue(string description, string keyword)
        {
            int value = 0;
            int endIndex = 0;
            int startIndex = 0;
            bool doGet = false;
            try
            {
                // get index of keyword
                var a = description.IndexOf(keyword);

                // go back until you reached the open parenthesis string
                var newDescription = description.Substring(0, a);
                for (int i = newDescription.Length - 1; i >= 0; i--)
                {
                    // since it's backwards, get closing parenthesis first and assign it as the end index
                    if (newDescription[i] == ')')
                    {
                        endIndex = i;
                        doGet = true;
                        continue;
                    }
                    else
                    {
                        if (doGet)
                        {
                            // check if open parenthesis and make it as start index
                            if (newDescription[i] == '(')
                            {
                                startIndex = i;
                                doGet = false;
                                break;
                            }
                        }
                    }
                }

                // get the target value
                // add 1 to start index to skip opening parenthesis
                // subtract 1 from end index to skip closing parenthesis
                value = Convert.ToInt32(newDescription.Substring(startIndex + 1, (endIndex - 1) - (startIndex)));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                MessageBox.Show("Issue on checking accomplishment! Please check logs at C:\\Axie_Logs", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            return value;
        }
        
    }
}
