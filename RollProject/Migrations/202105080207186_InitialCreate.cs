namespace RollProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        RarityId = c.Int(nullable: false),
                        Source = c.String(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Rarities", t => t.RarityId, cascadeDelete: true)
                .Index(t => t.RarityId);
            
            CreateTable(
                "dbo.Rarities",
                c => new
                    {
                        RarityId = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.RarityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "RarityId", "dbo.Rarities");
            DropIndex("dbo.Items", new[] { "RarityId" });
            DropTable("dbo.Rarities");
            DropTable("dbo.Items");
        }
    }
}
