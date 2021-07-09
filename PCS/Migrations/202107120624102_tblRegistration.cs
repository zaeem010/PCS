namespace PCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Name = c.String(),
                        Cnic = c.String(),
                        Designation = c.String(),
                        HosName = c.String(),
                        PreEmail = c.String(),
                        Email = c.String(),
                        HospTel = c.String(),
                        ClinicTel = c.String(),
                        ResTel = c.String(),
                        Mobile = c.String(),
                        Pmdc = c.String(),
                        Des = c.String(),
                        Arrival = c.DateTime(nullable: false),
                        Departure = c.DateTime(nullable: false),
                        Night = c.Int(nullable: false),
                        Room = c.Int(nullable: false),
                        fee = c.Int(nullable: false),
                        Hotel = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registrations");
        }
    }
}
