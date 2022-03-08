using Axie_Scholarship.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.Presenters
{
    public class AccomplishmentCheckerPresenter
    {
        string[] record;
        // win,lose or draw specific only
        public bool CheckIndividualRecord(List<DataGridViewRow> rows, int target, int frequency, string type)
        {
            int curFrequency = 0;
            try
            {
                foreach (DataGridViewRow row in rows)
                {
                    record = row.Cells["Record"].Value.ToString().Split('-');
                    switch (type)
                    {
                        case "win":
                            if (Convert.ToInt32(record[0]) >= target)
                            {
                                curFrequency++;
                                if (frequency == curFrequency) return true;
                            }
                            break;
                        case "lose":
                            if (Convert.ToInt32(record[1]) >= target)
                            {
                                curFrequency++;
                                if (frequency == curFrequency) return true;
                            }
                            break;
                        case "draw":
                            if (Convert.ToInt32(record[2]) >= target)
                            {
                                curFrequency++;
                                if (frequency == curFrequency) return true;
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
                return false;
            }

            return false;
        }

        // winning or losing percentage
        public bool CheckWinLosePercentage(List<DataGridViewRow> rows, bool isWinningPercentage = false)
        {
            try
            {
                int totalGames = 0;

                int totalWins = 0;
                foreach (DataGridViewRow row in rows)
                {
                    record = row.Cells["Record"].Value.ToString().Split('-');
                    totalGames += (Convert.ToInt32(record[0]) + Convert.ToInt32(record[1]) + Convert.ToInt32(record[2]));
                    totalWins += Convert.ToInt32(record[0]);

                }

                double percent = Convert.ToDouble(totalWins) / Convert.ToDouble(totalGames);

                if (isWinningPercentage)
                {
                    if (percent > 0.5) return true;
                }
                else
                {
                    if (percent < 0.5) return true;
                }
                
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return false;
            }

            return false;
        }

        // win, lose or draw total specific
        public bool CheckIndividualRecordTotal(List<DataGridViewRow> rows, int target, string type)
        {
            int total = 0;
            try
            {
                foreach (DataGridViewRow row in rows)
                {
                    record = row.Cells["Record"].Value.ToString().Split('-');
                    switch (type)
                    {
                        case "win":
                            total += Convert.ToInt32(record[0]);
                            if (total >= target)
                            {
                                return true;
                            }
                            break;
                        case "lose":
                            total += Convert.ToInt32(record[1]);
                            if (total >= target)
                            {
                                return true;
                            }
                            break;
                        case "draw":
                            total += Convert.ToInt32(record[2]);
                            if (total >= target)
                            {
                                return true;
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
                return false;
            }

            return false;
        }
    }
}
