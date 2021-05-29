using ITLBusiness.Abstract;
using ITLDataAccess.Concrete.Repository;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLBusiness.Concrete.Managers
{
    public class ControlManager : IListService<TblControl>
    {
        GenericRepository<TblControl> repository = new GenericRepository<TblControl>();

        public void Add(TblControl prop)
        {
            repository.Insert(prop);
        }

        public void Delete(TblControl prop)
        {
            repository.Delete(prop);
        }

        public List<TblControl> GetAllBL()
        {
            return repository.List();
        }
        public List<TblControl> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(TblControl prop)
        {
            repository.Update(prop);
        }
    }
}
