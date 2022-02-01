using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Helpers
{
    public static class ExpressionsHelper
    {
        public static bool NumbersOnly(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value, "[^0-9]"))
            {
                return false;
            }
            return true;
        }
    }
}
