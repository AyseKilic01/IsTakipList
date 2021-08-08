using ITLBusiness.Abstract;
using ITLDataAccess.Abstract;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;

namespace ITLBusiness.Concrete.Managers
{
    public class FirmManager : IListService<Firm>
    {
        #region objects

        IFirmDAL _dal;

        #endregion

        public FirmManager(IFirmDAL dal)
        {
            _dal = dal;
        }
        public List<Firm> GetAllBL(Firm p)
        {
            return _dal.List();
        }
        public List<Firm> GetAllBL()
        {
            return _dal.List();
        }
        public void Add(Firm p)
        {
            _dal.Insert(p);
        }

        public List<Firm> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Firm prop)
        {
            _dal.Update(prop);
        }

        public void Delete(Firm prop)
        {
            _dal.Delete(prop);
        }

        public Firm GetByID(int id)
        {
            return _dal.Get(x => x.ID == id);
        }
        //public int GetCount()
        //{
        //    return _dal.Count();
        //}
    }
}
