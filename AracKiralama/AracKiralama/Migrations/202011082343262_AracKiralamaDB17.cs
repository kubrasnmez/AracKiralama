namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB17 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Odemeler", "FaturaId", "dbo.Faturalar");
            DropIndex("dbo.Odemeler", new[] { "FaturaId" });
            DropColumn("dbo.Odemeler", "FaturaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Odemeler", "FaturaId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Odemeler", "FaturaId");
            AddForeignKey("dbo.Odemeler", "FaturaId", "dbo.Faturalar", "Id", cascadeDelete: true);
        }
    }
}
