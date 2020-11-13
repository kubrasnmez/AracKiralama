namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB16 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Odemeler", "KiraId", "dbo.Kiralar");
            DropIndex("dbo.Odemeler", new[] { "KiraId" });
            CreateTable(
                "dbo.Faturalar",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BaslangicTarih = c.DateTime(nullable: false),
                        BitisTarih = c.DateTime(nullable: false),
                        KiraGun = c.Int(nullable: false),
                        toplam_tutar = c.Double(nullable: false),
                        KiraId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kiralar", t => t.KiraId, cascadeDelete: true)
                .Index(t => t.KiraId);
            
            AddColumn("dbo.Odemeler", "FaturaId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Odemeler", "FaturaId");
            AddForeignKey("dbo.Odemeler", "FaturaId", "dbo.Faturalar", "Id", cascadeDelete: true);
            DropColumn("dbo.Odemeler", "KiraId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Odemeler", "KiraId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Odemeler", "FaturaId", "dbo.Faturalar");
            DropForeignKey("dbo.Faturalar", "KiraId", "dbo.Kiralar");
            DropIndex("dbo.Odemeler", new[] { "FaturaId" });
            DropIndex("dbo.Faturalar", new[] { "KiraId" });
            DropColumn("dbo.Odemeler", "FaturaId");
            DropTable("dbo.Faturalar");
            CreateIndex("dbo.Odemeler", "KiraId");
            AddForeignKey("dbo.Odemeler", "KiraId", "dbo.Kiralar", "Id", cascadeDelete: true);
        }
    }
}
