namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralar", "Marka", c => c.String());
            AddColumn("dbo.Kiralar", "Renk", c => c.String());
            AddColumn("dbo.Odemeler", "Renk", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Odemeler", "Renk");
            DropColumn("dbo.Kiralar", "Renk");
            DropColumn("dbo.Kiralar", "Marka");
        }
    }
}
