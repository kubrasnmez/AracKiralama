namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kiralar", "Saat", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kiralar", "Saat", c => c.Time(nullable: false, precision: 7));
        }
    }
}
