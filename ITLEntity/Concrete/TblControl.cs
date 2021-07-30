using ITLEntity.Abstract;

namespace ITLEntity.Concrete
{
    public class TblControl : IEntity
    {
        public int ID { get; set; }
        public int RowId { get; set; }
    }
}
