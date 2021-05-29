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
   public class AdminManager : IListService<TblAdmin>
    {
        GenericRepository<TblAdmin> repository = new GenericRepository<TblAdmin>();

        public void Add(TblAdmin prop)
        {
            repository.Insert(prop);
        }

        public void Delete(TblAdmin prop)
        {
            repository.Delete(prop);
        }

        public List<TblAdmin> GetAllBL()
        {
            return repository.List();
        }
        public List<TblAdmin> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(TblAdmin prop)
        {
            repository.Update(prop);
        }
    }
}
