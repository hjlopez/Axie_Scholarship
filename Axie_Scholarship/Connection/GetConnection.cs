using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Connection
{
    public static class GetConnection
    {
        public static string Connection()
        {
            return ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }
    }
}
