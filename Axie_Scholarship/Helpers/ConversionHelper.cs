using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Helpers
{
    public static class ConversionHelper
    {
        public static int ConvertToInteger(string value)
        {
            return Convert.ToInt32(value);
        }

        public static long ConvertToLong(string value)
        {
            return Convert.ToInt64(value);
        }

        public static string ReturnZeroIfNull(string value)
        {
            if (string.IsNullOrEmpty(value)) return "0";
            else return value;
        }
    }
}
