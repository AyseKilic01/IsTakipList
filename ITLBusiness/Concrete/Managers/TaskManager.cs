using ITLBusiness.Abstract;
using ITLDataAccess.Abstract;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;

namespace ITLBusiness.Concrete.Managers
{
    public class TaskManager : IListService<Tasks>
    {

        #region objects

        ITaskDAL _dal;

        #endregion

        public TaskManager(ITaskDAL dal)
        {
            _dal = dal;
        }
        public List<Tasks> GetAllBL(Tasks p)
        {
            return _dal.List();
        }
        public List<Tasks> GetAllBL()
        {
            return _dal.List();
        }
        public void Add(Tasks p)
        {
            _dal.Insert(p);
        }

        public List<Tasks> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Tasks prop)
        {
            _dal.Update(prop);
        }

        public void Delete(Tasks prop)
        {
            _dal.Delete(prop);
        }

        public Tasks GetByID(int id)
        {
            return _dal.Get(x => x.ID == id);
        }
        //public int GetCount()
        //{
        //    return _dal.Count();
        //}
    }
}
