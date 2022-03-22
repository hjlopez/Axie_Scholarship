using Axie_Scholarship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.ViewModels
{
    public class SLPBalanceViewModel
    {
        public long ScholarId { get; set; }
        public bool IsEarnedCashout { get; set; }

        public List<EarnCashOut> EarnCashOuts { get; set; }
        public List<BonusCashOut> BonusCashOuts { get; set; }

        public class EarnCashOut
        {
            public long CashOutId { get; set; }
            public decimal SLPValueTransferred { get; set; }
        }

        public class BonusCashOut
        {
            public long CashOutId { get; set; }
            public decimal IsExtraSLPApplied { get; set; }
        }
    }
}
