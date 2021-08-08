using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ITLDataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        T Get(Expression<Func<T, bool>> filter);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
