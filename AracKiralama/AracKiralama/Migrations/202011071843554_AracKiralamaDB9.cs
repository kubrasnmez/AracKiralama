namespace AracKiralama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracKiralamaDB9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralar", "KiraGun", c => c.Int(nullable: false));
            DropColumn("dbo.Kiralar", "Kacgun");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kiralar", "Kacgun", c => c.DateTime(nullable: false));
            DropColumn("dbo.Kiralar", "KiraGun");
        }
    }
}
