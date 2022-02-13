using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Models
{
    public class ExtraSLP
    {
        public long ExtrasId { get; set; }
        public long ScholarId { get; set; }
        public string Reason { get; set; }
        public int SLPValue { get; set; }
        public string DateAdded { get; set; }
        public bool IsApplied { get; set; }
    }
}
