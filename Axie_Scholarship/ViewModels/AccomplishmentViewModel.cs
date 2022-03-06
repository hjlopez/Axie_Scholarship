using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.ViewModels
{
    public partial class AccomplishmentViewModel
    {
        public PVPRecord Record { get; set; }
        public class PVPRecord
        {
            public int Id { get; set; }
            public int Wins { get; set; }
            public int Loss { get; set; }
            public int Draw { get; set; }
            public int Frequency { get; set; }
            public bool HasWinningPercentage { get; set; }
            public decimal Reward { get; set; }
            public bool IsPercent { get; set; }
            public int Type { get; set; }
        }
    }
}
