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
   public class StatusManager : IListService<Statu>
    {
        GenericRepository<Statu> repository = new GenericRepository<Statu>();

        public void Add(Statu prop)
        {
            repository.Insert(prop);
        }

        public void Delete(Statu prop)
        {
            repository.Delete(prop);
        }

        public List<Statu> GetAllBL()
        {
            return repository.List();
        }
        public List<Statu> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(Statu prop)
        {
            repository.Update(prop);
        }
    }
}
