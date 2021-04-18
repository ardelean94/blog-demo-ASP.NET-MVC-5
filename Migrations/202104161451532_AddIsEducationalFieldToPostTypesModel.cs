namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsEducationalFieldToPostTypesModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PostTypes", "IsEducationl", c => c.Boolean(nullable: false, defaultValue: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PostTypes", "IsEducationl");
        }
    }
}
