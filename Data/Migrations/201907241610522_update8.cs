namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update8 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductPacks", newName: "PackProducts");
            DropPrimaryKey("dbo.PackProducts");
            AddColumn("dbo.Invoices", "idClient", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "idProduit", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "idQuotation", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "Quantite", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "SumInvoice", c => c.Single(nullable: false));
            AddColumn("dbo.Invoices", "DateInvoice", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.PackProducts", new[] { "Pack_Id", "Product_Id" });
            CreateIndex("dbo.Invoices", "idClient");
            CreateIndex("dbo.Invoices", "idProduit");
            CreateIndex("dbo.Invoices", "idQuotation");
            AddForeignKey("dbo.Invoices", "idClient", "dbo.Clients", "id", cascadeDelete: true);
            AddForeignKey("dbo.Invoices", "idProduit", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Invoices", "idQuotation", "dbo.Quotations", "Id", cascadeDelete: true);
            DropColumn("dbo.Invoices", "Total");
            DropColumn("dbo.Invoices", "Date_invoice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "Date_invoice", c => c.DateTime(nullable: false));
            AddColumn("dbo.Invoices", "Total", c => c.Single(nullable: false));
            DropForeignKey("dbo.Invoices", "idQuotation", "dbo.Quotations");
            DropForeignKey("dbo.Invoices", "idProduit", "dbo.Products");
            DropForeignKey("dbo.Invoices", "idClient", "dbo.Clients");
            DropIndex("dbo.Invoices", new[] { "idQuotation" });
            DropIndex("dbo.Invoices", new[] { "idProduit" });
            DropIndex("dbo.Invoices", new[] { "idClient" });
            DropPrimaryKey("dbo.PackProducts");
            DropColumn("dbo.Invoices", "DateInvoice");
            DropColumn("dbo.Invoices", "SumInvoice");
            DropColumn("dbo.Invoices", "Quantite");
            DropColumn("dbo.Invoices", "idQuotation");
            DropColumn("dbo.Invoices", "idProduit");
            DropColumn("dbo.Invoices", "idClient");
            AddPrimaryKey("dbo.PackProducts", new[] { "Product_Id", "Pack_Id" });
            RenameTable(name: "dbo.PackProducts", newName: "ProductPacks");
        }
    }
}
