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
        public bool CheckWinsOnce(List<DataGridViewRow> rows, string target)
        {
            string[] record;
            try
            {
                foreach (DataGridViewRow row in rows)
                {
                    record = row.Cells["Record"].Value.ToString().Split('-');
                    if (Convert.ToInt32(target) == Convert.ToInt32(record[0]))
                    {
                        return true;
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
