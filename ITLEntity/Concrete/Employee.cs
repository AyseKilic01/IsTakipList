using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLEntity.Concrete
{
    public class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        public int departmentID { get; set; }
        public bool statu { get; set; }
    }
}
