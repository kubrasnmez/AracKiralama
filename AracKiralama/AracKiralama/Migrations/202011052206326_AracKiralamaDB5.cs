namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Araclar", "KiraDurum", c => c.Boolean(nullable: false));
            DropColumn("dbo.Kiralar", "Kira_Durum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kiralar", "Kira_Durum", c => c.Boolean(nullable: false));
            DropColumn("dbo.Araclar", "KiraDurum");
        }
    }
}
