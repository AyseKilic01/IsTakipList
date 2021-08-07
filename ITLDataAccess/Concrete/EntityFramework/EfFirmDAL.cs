using ITLDataAccess.Abstract;
using ITLDataAccess.Concrete.Repository;
using ITLEntity.Concrete;

namespace ITLDataAccess.Concrete.EntityFramework
{
    public class EfFirmDAL : GenericRepository<Firm>, IFirmDAL
    {
    }
}
