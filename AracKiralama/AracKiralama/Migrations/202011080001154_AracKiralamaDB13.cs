namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Odemeler", "PlakaNo", c => c.String());
            AddColumn("dbo.Odemeler", "MusteriTc", c => c.String());
            AddColumn("dbo.Odemeler", "BaslangicTarih", c => c.DateTime(nullable: false));
            AddColumn("dbo.Odemeler", "BitisTarih", c => c.DateTime(nullable: false));
            AddColumn("dbo.Odemeler", "KiraGun", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Odemeler", "KiraGun");
            DropColumn("dbo.Odemeler", "BitisTarih");
            DropColumn("dbo.Odemeler", "BaslangicTarih");
            DropColumn("dbo.Odemeler", "MusteriTc");
            DropColumn("dbo.Odemeler", "PlakaNo");
        }
    }
}
