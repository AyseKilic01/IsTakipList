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
    public class EmployeeManager : IListService<Employee>
    {
        GenericRepository<Employee> repository = new GenericRepository<Employee>();

        public void Add(Employee prop)
        {
            repository.Insert(prop);
        }

        public void Delete(Employee prop)
        {
            repository.Delete(prop);
        }

        public List<Employee> GetAllBL()
        {
            return repository.List();
        }
        public List<Employee> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(Employee prop)
        {
            repository.Update(prop);
        }
    }
}
