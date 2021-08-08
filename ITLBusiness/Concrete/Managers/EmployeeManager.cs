using ITLBusiness.Abstract;
using ITLDataAccess.Abstract;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;

namespace ITLBusiness.Concrete.Managers
{
    public class EmployeeManager : IListService<TblEmployee>
    {
        #region objects

        ITblEmployeeDAL _dal;

        #endregion

        public EmployeeManager(ITblEmployeeDAL dal)
        {
            _dal = dal;
        }
        public List<TblEmployee> GetAllBL(TblEmployee p)
        {
            return _dal.List();
        }
        public List<TblEmployee> GetAllBL()
        {
            return _dal.List();
        }
        public void Add(TblEmployee p)
        {
            _dal.Insert(p);
        }

        public List<TblEmployee> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TblEmployee prop)
        {
            _dal.Update(prop);
        }

        public void Delete(TblEmployee prop)
        {
            _dal.Delete(prop);
        }

        public TblEmployee GetByID(int id)
        {
            return _dal.Get(x => x.ID == id);
        }
        //public int GetCount()
        //{
        //    return _dal.Count();
        //}
    }
}
