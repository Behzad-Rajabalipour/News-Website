namespace WebApplication11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Description", c => c.String());
            AddColumn("dbo.T_NewsGroups", "Description", c => c.String());
            AddColumn("dbo.Users", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Description");
            DropColumn("dbo.T_NewsGroups", "Description");
            DropColumn("dbo.Comments", "Description");
        }
    }
}
