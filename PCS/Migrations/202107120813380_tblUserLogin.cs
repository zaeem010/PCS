namespace PCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblUserLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Pass = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserLogins");
        }
    }
}
