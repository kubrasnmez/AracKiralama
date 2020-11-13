namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB18 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Faturalar", "KiraId", "dbo.Kiralar");
            DropIndex("dbo.Faturalar", new[] { "KiraId" });
            AddColumn("dbo.Odemeler", "PlakaNo", c => c.String());
            AddColumn("dbo.Odemeler", "MusteriTC", c => c.String());
            DropTable("dbo.Faturalar");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Odemeler", "MusteriTC");
            DropColumn("dbo.Odemeler", "PlakaNo");
            CreateIndex("dbo.Faturalar", "KiraId");
            AddForeignKey("dbo.Faturalar", "KiraId", "dbo.Kiralar", "Id", cascadeDelete: true);
        }
    }
}
