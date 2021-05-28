using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLEntity.Concrete
{
    public class Task
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
