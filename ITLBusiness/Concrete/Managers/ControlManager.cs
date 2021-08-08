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
    public class ControlManager : IListService<TblControl>
    {
        #region objects

        ITblControlDAL _dal;

        #endregion

        public ControlManager(ITblControlDAL dal)
        {
            _dal = dal;
        }
        public List<TblControl> GetAllBL(TblControl p)
        {
            return _dal.List();
        }
        public List<TblControl> GetAllBL()
        {
            return _dal.List();
        }
        public void Add(TblControl p)
        {
            _dal.Insert(p);
        }

        public List<TblControl> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TblControl prop)
        {
            _dal.Update(prop);
        }

        public void Delete(TblControl prop)
        {
            _dal.Delete(prop);
        }

        public TblControl GetByID(int id)
        {
            return _dal.Get(x => x.ID == id);
        }
        //public int GetCount()
        //{
        //    return _dal.Count();
        //}


    }
}
