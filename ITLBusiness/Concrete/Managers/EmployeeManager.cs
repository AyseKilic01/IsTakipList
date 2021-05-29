﻿using ITLBusiness.Abstract;
using ITLDataAccess.Concrete.Repository;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLBusiness.Concrete.Managers
{
    public class EmployeeManager : IListService<TblEmployee>
    {
        GenericRepository<TblEmployee> repository = new GenericRepository<TblEmployee>();

        public void Add(TblEmployee prop)
        {
            repository.Insert(prop);
        }

        public void Delete(TblEmployee prop)
        {
            repository.Delete(prop);
        }

        public List<TblEmployee> GetAllBL()
        {
            return repository.List();
        }
        public List<TblEmployee> GetAllBL(int id)
        {
            return repository.List().Where(x => x.ID == id).ToList();
        }

        public void Update(TblEmployee prop)
        {
            repository.Update(prop);
        }
    }
}
