using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLEntity.Concrete
{
   public class TblDetailTask
    {
        public int ID { get; set; }
        public string task { get; set; }
        public string statement { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
    }
}
