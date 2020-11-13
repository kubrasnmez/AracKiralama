namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralar", "Kacgun", c => c.Int(nullable: false));
            AddColumn("dbo.Kiralar", "Hasar_tutar", c => c.Double(nullable: false));
            AddColumn("dbo.Kiralar", "Toplam_tutar", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kiralar", "Toplam_tutar");
            DropColumn("dbo.Kiralar", "Hasar_tutar");
            DropColumn("dbo.Kiralar", "Kacgun");
        }
    }
}
