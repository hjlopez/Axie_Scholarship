using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Axie_Scholarship.Helpers
{
    public static class ExpressionsHelper
    {
        public static bool NumbersOnly(string value)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(value))
            {
                return false;
            }
            return true;
        }
    }
}
