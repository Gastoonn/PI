namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reclamations", "Client_id", "dbo.Clients");
            DropIndex("dbo.Reclamations", new[] { "Client_id" });
            RenameColumn(table: "dbo.Reclamations", name: "Client_id", newName: "idClient");
            AlterColumn("dbo.Reclamations", "idClient", c => c.Int(nullable: false));
            CreateIndex("dbo.Reclamations", "idClient");
            AddForeignKey("dbo.Reclamations", "idClient", "dbo.Clients", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reclamations", "idClient", "dbo.Clients");
            DropIndex("dbo.Reclamations", new[] { "idClient" });
            AlterColumn("dbo.Reclamations", "idClient", c => c.Int());
            RenameColumn(table: "dbo.Reclamations", name: "idClient", newName: "Client_id");
            CreateIndex("dbo.Reclamations", "Client_id");
            AddForeignKey("dbo.Reclamations", "Client_id", "dbo.Clients", "id");
        }
    }
}
