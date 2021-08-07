using ITLDataAccess.Abstract;
using ITLDataAccess.Concrete.Repository;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLDataAccess.Concrete.EntityFramework
{
    public class EfTblControlDAL : GenericRepository<TblControl>, ITblControlDAL
    {
    }
}
