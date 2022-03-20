using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Models
{
    public class Scholar
    {
        public long ScholarId { get; set; }
        public string ScholarName { get; set; }
        public string DateAdded { get; set; }
        public bool IsActive { get; set; }
        public int CutOffDays { get; set; }
        public int ScholarCut { get; set; }
        public bool IsSLPCashout { get; set; }
        public int SLPToTransfer { get; set; }
    }
}
