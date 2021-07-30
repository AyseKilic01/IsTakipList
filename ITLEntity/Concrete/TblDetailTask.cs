using ITLEntity.Abstract;
using System;

namespace ITLEntity.Concrete
{
    public class TblDetailTask : IEntity
    {
        public int ID { get; set; }
        public string task { get; set; }
        public string statement { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
    }
}
