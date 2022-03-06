using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Models
{
    public class Accomplishments
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Reward { get; set; }
        public bool IsPercent { get; set; }
        public bool IsPenalty { get; set; }
    }
}
