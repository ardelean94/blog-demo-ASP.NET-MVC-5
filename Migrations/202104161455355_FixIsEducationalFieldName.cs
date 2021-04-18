namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixIsEducationalFieldName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PostTypes", "IsEducational", c => c.Boolean(nullable: false));
            DropColumn("dbo.PostTypes", "IsEducationl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostTypes", "IsEducationl", c => c.Boolean(nullable: false));
            DropColumn("dbo.PostTypes", "IsEducational");
        }
    }
}
