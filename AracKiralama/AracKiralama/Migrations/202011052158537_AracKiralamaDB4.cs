namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralar", "Kira_Durum", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kiralar", "Kira_Durum");
        }
    }
}
