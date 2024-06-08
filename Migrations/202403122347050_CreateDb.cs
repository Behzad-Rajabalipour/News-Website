namespace WebApplication11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        commentId = c.Int(nullable: false, identity: true),
                        commentText = c.String(nullable: false, maxLength: 100),
                        Name = c.String(),
                        Email = c.String(nullable: false, maxLength: 100),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        NewsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.commentId)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .Index(t => t.NewsId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        NewsTitle = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        ImageName = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        See = c.Int(nullable: false),
                        Like = c.Int(nullable: false),
                        NewsGroupId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NewsId)
                .ForeignKey("dbo.T_NewsGroups", t => t.NewsGroupId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.NewsGroupId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.T_NewsGroups",
                c => new
                    {
                        NewsGroupId = c.Int(nullable: false),
                        NewsTitle = c.String(nullable: false, maxLength: 100),
                        ImageName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.NewsGroupId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        MobileNumber = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "NewsId", "dbo.News");
            DropForeignKey("dbo.News", "UserId", "dbo.Users");
            DropForeignKey("dbo.News", "NewsGroupId", "dbo.T_NewsGroups");
            DropIndex("dbo.News", new[] { "UserId" });
            DropIndex("dbo.News", new[] { "NewsGroupId" });
            DropIndex("dbo.Comments", new[] { "NewsId" });
            DropTable("dbo.Users");
            DropTable("dbo.T_NewsGroups");
            DropTable("dbo.News");
            DropTable("dbo.Comments");
        }
    }
}
