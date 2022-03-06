using Axie_Scholarship.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Interface
{
    public interface IAccomplishment
    {
        string GenerateDescription(AccomplishmentViewModel vm);
        bool Validate(AccomplishmentViewModel vm);
        void GenerateStartDescription(bool isBonus, bool isPercent, decimal value);
    }
}
