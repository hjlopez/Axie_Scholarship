using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Interface
{
    public interface IData<T>
    {
        DataTable LoadData(T model);
        bool Insert(T model);
        bool Delete(T model);
        bool Update(T model);
    }
}
