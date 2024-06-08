namespace WebApplication11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "MobileNumber", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "IsActive", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "IsActive", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "MobileNumber", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
