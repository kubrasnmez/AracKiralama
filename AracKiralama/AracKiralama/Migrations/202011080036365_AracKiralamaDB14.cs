namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB14 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Odemeler", "PlakaNo");
            DropColumn("dbo.Odemeler", "MusteriTc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Odemeler", "MusteriTc", c => c.String());
            AddColumn("dbo.Odemeler", "PlakaNo", c => c.String());
        }
    }
}
