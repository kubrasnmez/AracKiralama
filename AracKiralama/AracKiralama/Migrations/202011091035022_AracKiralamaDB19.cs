namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Odemeler", "Marka", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Odemeler", "Marka");
        }
    }
}
