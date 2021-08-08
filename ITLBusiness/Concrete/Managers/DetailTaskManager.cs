using ITLBusiness.Abstract;
using ITLDataAccess.Abstract;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;

namespace ITLBusiness.Concrete.Managers
{
    public class DetailTaskManager : IListService<TblDetailTask>
    {
        #region objects

        ITblDetailTaskDAL _dal;

        #endregion

        public DetailTaskManager(ITblDetailTaskDAL dal)
        {
            _dal = dal;
        }
        public List<TblDetailTask> GetAllBL(TblDetailTask p)
        {
            return _dal.List();
        }
        public List<TblDetailTask> GetAllBL()
        {
            return _dal.List();
        }
        public void Add(TblDetailTask p)
        {
            _dal.Insert(p);
        }

        public List<TblDetailTask> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TblDetailTask prop)
        {
            _dal.Update(prop);
        }

        public void Delete(TblDetailTask prop)
        {
            _dal.Delete(prop);
        }

        public TblDetailTask GetByID(int id)
        {
            return _dal.Get(x => x.ID == id);
        }
        //public int GetCount()
        //{
        //    return _dal.Count();
        //}
    }
}
