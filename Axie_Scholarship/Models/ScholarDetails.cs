using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Models
{
    public class ScholarDetails
    {
        public long ScholarDetailId { get; set; }
        public long ScholarId { get; set; }
        public int SLPStart { get; set; }
        public int SLPEnd { get; set; }
        public int SLPEarnedToday { get; set; }
        public string DateEarned { get; set; }
        public bool IsCashedOut { get; set; }
        public int PVPWin { get; set; }
        public int PVPLose { get; set; }
        public int PVPDraw { get; set; }
        public int CurrentMMR { get; set; }
    }
}
