using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Models
{
    public class CashOut
    {
        public long CashOutId { get; set; }
        public long ScholarId { get; set; }
        public int TotalSLP { get; set; }
        public decimal ScholarSLP { get; set; }
        public int ExtraSLP { get; set; }
        public string CashOutDate { get; set; }
        public decimal SLPValue { get; set; }
        public decimal AmountReceived { get; set; }
        public bool IsSlpCashOut { get; set; }
        public bool IsExtraSLPApplied { get; set; }
        public int SLPBalance { get; set; }
    }
}
