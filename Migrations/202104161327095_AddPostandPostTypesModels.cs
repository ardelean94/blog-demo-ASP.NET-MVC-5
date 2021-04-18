namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostandPostTypesModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        NoOfLikes = c.Int(nullable: false),
                        Type_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostTypes", t => t.Type_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.PostTypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IsBusiness = c.Boolean(nullable: false),
                        IsEntertainment = c.Boolean(nullable: false),
                        IsCasual = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Type_Id", "dbo.PostTypes");
            DropIndex("dbo.Posts", new[] { "Type_Id" });
            DropTable("dbo.PostTypes");
            DropTable("dbo.Posts");
        }
    }
}
