using ITLEntity.Abstract;

namespace ITLEntity.Concrete
{
    public class TblDepartment : IEntity
    {
        public int ID { get; set; }
        public string departcode { get; set; }
    }
}
