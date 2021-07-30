using ITLEntity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace ITLEntity.Concrete
{
    public class TblEmployee : IEntity
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        public int departmentID { get; set; }
        public bool statu { get; set; }
    }
}
