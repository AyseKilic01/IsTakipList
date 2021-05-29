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
   public class TaskManager : IListService<Tasks>
    {
        GenericRepository<Tasks> repository = new GenericRepository<Tasks>();

        public void Add(Tasks prop)
        {
            repository.Insert(prop);
        }

        public void Delete(Tasks prop)
        {
            repository.Delete(prop);
        }

        public List<Tasks> GetAllBL()
        {
            return repository.List();
        }
        public List<Tasks> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(Tasks prop)
        {
            repository.Update(prop);
        }
    }
}
