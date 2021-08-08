namespace ITLDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Firms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        author = c.String(),
                        phone = c.String(),
                        mail = c.String(),
                        sector = c.String(),
                        city = c.String(),
                        district = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        statement = c.String(),
                        passive = c.Boolean(nullable: false),
                        isTask = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        commissioner = c.Int(nullable: false),
                        employee = c.Int(nullable: false),
                        statement = c.String(),
                        statu = c.String(),
                        date = c.DateTime(nullable: false),
                        passive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblAdmins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblControls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RowId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblDepartments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        departcode = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblDetailTasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        task = c.String(),
                        statement = c.String(),
                        date = c.DateTime(nullable: false),
                        time = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblEmployees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        mail = c.String(),
                        phone = c.String(),
                        departmentID = c.Int(nullable: false),
                        statu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblEmployees");
            DropTable("dbo.TblDetailTasks");
            DropTable("dbo.TblDepartments");
            DropTable("dbo.TblControls");
            DropTable("dbo.TblAdmins");
            DropTable("dbo.Tasks");
            DropTable("dbo.Status");
            DropTable("dbo.Firms");
        }
    }
}
