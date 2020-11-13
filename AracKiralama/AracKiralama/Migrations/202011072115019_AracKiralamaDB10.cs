namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Odemeler", "toplam_tutar", c => c.Double(nullable: false));
            DropColumn("dbo.Odemeler", "Odenecektutar");
            DropColumn("dbo.Odemeler", "OdemeSekli");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Odemeler", "OdemeSekli", c => c.Int(nullable: false));
            AddColumn("dbo.Odemeler", "Odenecektutar", c => c.Double(nullable: false));
            DropColumn("dbo.Odemeler", "toplam_tutar");
        }
    }
}
