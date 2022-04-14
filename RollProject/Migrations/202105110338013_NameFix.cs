namespace RollProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rarities", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rarities", "Name");
        }
    }
}
