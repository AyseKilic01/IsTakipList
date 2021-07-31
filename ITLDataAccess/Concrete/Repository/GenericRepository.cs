using ITLDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ITLDataAccess.Concrete.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        #region objects
        //IsTakipListEntities entities = new IsTakipListEntities(); //provide sql
        DbSet<T> _object;
        #endregion
        #region const
        public GenericRepository()
        {
            //_object = entities.Set<T>();

        }
        #endregion

        public void Delete(T p)
        {
            _object.Remove(p);
            //entities.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            //entities.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            //entities.SaveChanges();
        }
    }
}
