using Axie_Scholarship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.ViewModels
{
    public class ScholarDetailViewModel
    {
        public List<ScholarDetails> ScholarDetailsList { get; set; }
        public ScholarDetails ScholarDetails { get; set; }
        public long ScholarId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public short CashOutType { get; set; }
    }
}
