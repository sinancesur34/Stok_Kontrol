namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Uruns", "KategoriID", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "KategoriID" });
            RenameColumn(table: "dbo.Uruns", name: "KategoriID", newName: "KategoriAd");
            DropPrimaryKey("dbo.Kategoris");
            AlterColumn("dbo.Kategoris", "KategoriID", c => c.Int(nullable: false));
            AlterColumn("dbo.Kategoris", "KategoriAd", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Uruns", "KategoriAd", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Kategoris", "KategoriAd");
            CreateIndex("dbo.Uruns", "KategoriAd");
            AddForeignKey("dbo.Uruns", "KategoriAd", "dbo.Kategoris", "KategoriAd");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uruns", "KategoriAd", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "KategoriAd" });
            DropPrimaryKey("dbo.Kategoris");
            AlterColumn("dbo.Uruns", "KategoriAd", c => c.Int(nullable: false));
            AlterColumn("dbo.Kategoris", "KategoriAd", c => c.String(maxLength: 50));
            AlterColumn("dbo.Kategoris", "KategoriID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Kategoris", "KategoriID");
            RenameColumn(table: "dbo.Uruns", name: "KategoriAd", newName: "KategoriID");
            CreateIndex("dbo.Uruns", "KategoriID");
            AddForeignKey("dbo.Uruns", "KategoriID", "dbo.Kategoris", "KategoriID", cascadeDelete: true);
        }
    }
}
