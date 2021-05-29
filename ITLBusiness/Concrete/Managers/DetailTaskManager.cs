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
   public class DetailTaskManager : IListService<TblDetailTask>
    {
        GenericRepository<TblDetailTask> repository = new GenericRepository<TblDetailTask>();

        public void Add(TblDetailTask prop)
        {
            repository.Insert(prop);
        }

        public void Delete(TblDetailTask prop)
        {
            repository.Delete(prop);
        }

        public List<TblDetailTask> GetAllBL()
        {
            return repository.List();
        }
        public List<TblDetailTask> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(TblDetailTask prop)
        {
            repository.Update(prop);
        }
    }
}
