namespace PCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblSession1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sessions", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sessions", "Name");
        }
    }
}
