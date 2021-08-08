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
   public class StatusManager : IListService<Statu>
    {
        #region objects

        IStatuDAL _dal;

        #endregion

        public StatusManager(IStatuDAL dal)
        {
            _dal = dal;
        }
        public List<Statu> GetAllBL(Statu p)
        {
            return _dal.List();
        }
        public List<Statu> GetAllBL()
        {
            return _dal.List();
        }
        public void Add(Statu p)
        {
            _dal.Insert(p);
        }

        public List<Statu> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Statu prop)
        {
            _dal.Update(prop);
        }

        public void Delete(Statu prop)
        {
            _dal.Delete(prop);
        }

        public Statu GetByID(int id)
        {
            return _dal.Get(x => x.ID == id);
        }
        //public int GetCount()
        //{
        //    return _dal.Count();
        //}
    }
}
