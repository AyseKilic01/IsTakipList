using ITLDataAccess.Abstract;
using ITLDataAccess.Concrete.Repository;
using ITLEntity.Concrete;

namespace ITLDataAccess.Concrete
{
    public class TblControlDAL : GenericRepository<TblControl>, ITblControlDAL
    {
    }
}
