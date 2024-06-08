namespace WebApplication11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T_NewsGroups", "NewsGroupTitle", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.T_NewsGroups", "NewsTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.T_NewsGroups", "NewsTitle", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.T_NewsGroups", "NewsGroupTitle");
        }
    }
}
