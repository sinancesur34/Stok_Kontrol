namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Uruns", "UrunKategori");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uruns", "UrunKategori", c => c.String(maxLength: 100));
        }
    }
}
