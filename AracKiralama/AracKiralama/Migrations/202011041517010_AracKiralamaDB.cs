namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musteriler", "MusteriTC", c => c.String());
            AlterColumn("dbo.Musteriler", "Telno", c => c.String());
            AlterColumn("dbo.Musteriler", "Ehliyetno", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musteriler", "Ehliyetno", c => c.Double(nullable: false));
            AlterColumn("dbo.Musteriler", "Telno", c => c.Double(nullable: false));
            AlterColumn("dbo.Musteriler", "MusteriTC", c => c.Double(nullable: false));
        }
    }
}
