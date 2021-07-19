namespace PCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblSession : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sessions");
        }
    }
}
