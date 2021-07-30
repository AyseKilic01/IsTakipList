using ITLEntity.Abstract;

namespace ITLEntity.Concrete
{
    public class Statu : IEntity
    {
        public int  ID { get; set; }
        public string  statement { get; set; }
        public bool passive { get; set; }
        public bool isTask { get; set; }
    }
}
