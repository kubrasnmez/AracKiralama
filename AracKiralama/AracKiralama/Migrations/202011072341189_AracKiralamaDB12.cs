namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB12 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kiralar", "Kiradami");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kiralar", "Kiradami", c => c.Boolean(nullable: false));
        }
    }
}
