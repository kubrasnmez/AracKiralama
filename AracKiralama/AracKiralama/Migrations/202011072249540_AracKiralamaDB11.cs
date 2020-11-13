namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralar", "Kiradami", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kiralar", "Kiradami");
        }
    }
}
