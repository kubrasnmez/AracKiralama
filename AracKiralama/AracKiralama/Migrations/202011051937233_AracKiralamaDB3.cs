namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralar", "Hasar_durum", c => c.String());
            AlterColumn("dbo.Kiralar", "Hasar", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kiralar", "Hasar", c => c.String());
            DropColumn("dbo.Kiralar", "Hasar_durum");
        }
    }
}
