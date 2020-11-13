namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Odemeler", "ToplamTutar", c => c.Double(nullable: false));
            DropColumn("dbo.Odemeler", "toplam_tutar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Odemeler", "toplam_tutar", c => c.Double(nullable: false));
            DropColumn("dbo.Odemeler", "ToplamTutar");
        }
    }
}
