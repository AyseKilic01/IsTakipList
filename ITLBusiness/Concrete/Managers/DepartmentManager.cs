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
   public class DepartmentManager : IListService<TblDepartment>
    {
        #region objects
        GenericRepository<TblDepartment> repository = new GenericRepository<TblDepartment>();
        #endregion
        public void Add(TblDepartment prop)
        {
            repository.Insert(prop);
        }

        public void Delete(TblDepartment prop)
        {
            repository.Delete(prop);
        }

        public List<TblDepartment> GetAllBL()
        {
            return repository.List();
        }
        public List<TblDepartment> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(TblDepartment prop)
        {
            repository.Update(prop);
        }
    }
}
