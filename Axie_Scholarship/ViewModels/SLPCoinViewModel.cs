using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.ViewModels
{
    public class SLPCoinViewModel
    {
        public MarketData market_data { get; set; }

        public class MarketData
        {
            public CurrentPrice current_price { get; set; }
        }
        public class CurrentPrice
        {
            public decimal php { get; set; }
        }
    }
}
