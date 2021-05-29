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
    public class FirmManager : IListService<Firm>
    {
        GenericRepository<Firm> repository = new GenericRepository<Firm>();

        public void Add(Firm prop)
        {
            repository.Insert(prop);
        }

        public void Delete(Firm prop)
        {
            repository.Delete(prop);
        }

        public List<Firm> GetAllBL()
        {
            return repository.List();
        }
        public List<Firm> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(Firm prop)
        {
            repository.Update(prop);
        }
    }
}
