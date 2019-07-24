namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reclamations", "Client_id", "dbo.Clients");
            DropIndex("dbo.Reclamations", new[] { "Client_id" });
            DropColumn("dbo.Reclamations", "dateReclamation");
            DropColumn("dbo.Reclamations", "CategorieReclamation");
            DropColumn("dbo.Reclamations", "SujetReclamation");
            DropColumn("dbo.Reclamations", "textReclamation");
            DropColumn("dbo.Reclamations", "EtatReclamation");
            DropColumn("dbo.Reclamations", "Client_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reclamations", "Client_id", c => c.Int());
            AddColumn("dbo.Reclamations", "EtatReclamation", c => c.String());
            AddColumn("dbo.Reclamations", "textReclamation", c => c.String());
            AddColumn("dbo.Reclamations", "SujetReclamation", c => c.String());
            AddColumn("dbo.Reclamations", "CategorieReclamation", c => c.String());
            AddColumn("dbo.Reclamations", "dateReclamation", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Reclamations", "Client_id");
            AddForeignKey("dbo.Reclamations", "Client_id", "dbo.Clients", "id");
        }
    }
}
