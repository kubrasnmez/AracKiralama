namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kiralar", "Kacgun", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Kiralar", "Toplam_tutar", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kiralar", "Toplam_tutar", c => c.Int(nullable: false));
            AlterColumn("dbo.Kiralar", "Kacgun", c => c.Int(nullable: false));
        }
    }
}
