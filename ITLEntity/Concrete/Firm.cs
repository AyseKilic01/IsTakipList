using ITLEntity.Abstract;

namespace ITLEntity.Concrete
{
    public class Firm : IEntity
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string sector { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string address { get; set; }
    }
}
