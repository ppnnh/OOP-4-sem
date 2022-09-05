namespace OOP_LAB_12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        ProviderId = c.Int(nullable: false, identity: true),
                        ProviderName = c.String(),
                        ProviderLocation = c.String(),
                    })
                .PrimaryKey(t => t.ProviderId);
            
            CreateTable(
                "dbo.Smartphones",
                c => new
                    {
                        SmartphoneId = c.Int(nullable: false, identity: true),
                        SmartphoneName = c.String(),
                        YearOfIssue = c.Int(nullable: false),
                        Cost = c.Double(nullable: false),
                        ProviderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SmartphoneId)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: true)
                .Index(t => t.ProviderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Smartphones", "ProviderId", "dbo.Providers");
            DropIndex("dbo.Smartphones", new[] { "ProviderId" });
            DropTable("dbo.Smartphones");
            DropTable("dbo.Providers");
        }
    }
}
