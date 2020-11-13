namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kiralar", "Ucret", c => c.Int(nullable: false));
            AlterColumn("dbo.Kiralar", "Hasar_tutar", c => c.Int(nullable: false));
            AlterColumn("dbo.Kiralar", "Toplam_tutar", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kiralar", "Toplam_tutar", c => c.Double(nullable: false));
            AlterColumn("dbo.Kiralar", "Hasar_tutar", c => c.Double(nullable: false));
            AlterColumn("dbo.Kiralar", "Ucret", c => c.Double(nullable: false));
        }
    }
}
