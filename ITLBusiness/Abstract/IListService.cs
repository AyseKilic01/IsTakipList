using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLBusiness.Abstract
{
    public interface IListService<T> where T : class
    {
        List<T> GetAllBL();
        List<T> GetAllBL(int id);
        void Add(T prop);
        void Update(T prop);
        void Delete(T prop);
    }
}
