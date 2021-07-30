using ITLEntity.Abstract;
using System;

namespace ITLEntity.Concrete
{
    public class Tasks : IEntity
    {
        public int ID { get; set; }
        public int commissioner { get; set; }
        public int employee { get; set; }
        public string statement { get; set; }
        public string statu { get; set; }
        public DateTime date { get; set; }
        public bool passive { get; set; }
    }
}
