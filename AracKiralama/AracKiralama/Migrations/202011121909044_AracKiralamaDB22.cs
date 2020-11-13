namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB22 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Odemeler", "Renk");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Odemeler", "Renk", c => c.String());
        }
    }
}
