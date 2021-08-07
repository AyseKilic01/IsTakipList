using ITLEntity.Concrete;
using System.Data.Entity;

namespace ITLDataAccess.Concrete
{
    public class IsTakiplistEntites : DbContext
    {
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Statu> Status { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TblAdmin> TblAdmins { get; set; }
        public DbSet<TblControl> TblControls { get; set; }
        public DbSet<TblDepartment> TblDepartments { get; set; }
        public DbSet<TblDetailTask> TblDetailTasks { get; set; }
        public DbSet<TblEmployee> TblEmployees { get; set; }
    }
}
