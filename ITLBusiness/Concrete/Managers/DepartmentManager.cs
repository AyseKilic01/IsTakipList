using ITLBusiness.Abstract;
using ITLDataAccess.Abstract;
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
        //GenericRepository<TblDepartment> repository = new GenericRepository<TblDepartment>();
        #endregion

        ITblDepartmentDAL _dal;

        public DepartmentManager(ITblDepartmentDAL dal)
        {
            _dal = dal;
        }
        public List<TblDepartment> GetAllBL(TblDepartment p)
        {
            return _dal.List();
        }
        public List<TblDepartment> GetAllBL()
        {
            return _dal.List();
        }
        public void Add(TblDepartment p)
        {
            _dal.Insert(p);
        }

        public List<TblDepartment> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TblDepartment prop)
        {
            _dal.Update(prop);
        }

        public void Delete(TblDepartment prop)
        {
            _dal.Delete(prop);
        }

        public TblDepartment GetByID(int id)
        {
            return _dal.Get(x => x.ID == id);
        }
        //public int GetCount()
        //{
        //    return _dal.Count();
        //}


    }
}
