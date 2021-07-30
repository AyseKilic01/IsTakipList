using ITLEntity.Abstract;

namespace ITLEntity.Concrete
{
    public class TblAdmin : IEntity
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
