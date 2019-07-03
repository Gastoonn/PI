namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fluentAPI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idPanier = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Single(nullable: false),
                        Date_invoice = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Packs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        date_deb = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        date_expiration = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        idCLient = c.Int(nullable: false),
                        idQuotation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Category = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        idStore = c.Int(nullable: false),
                        idProduct = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Product_Id = c.Int(),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.idStore, t.idProduct })
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Store_Id);
            
            CreateTable(
                "dbo.Quotations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Single(nullable: false),
                        Date_expiration = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TVA = c.Single(nullable: false),
                        QuoteNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reclamations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adresse = c.String(),
                        Tel = c.String(),
                        Horaire_ouverture = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Firstname = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Tel = c.String(),
                        Adresse = c.String(),
                        Date_birth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCartPacks",
                c => new
                    {
                        ShoppingCart_Id = c.Int(nullable: false),
                        Pack_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingCart_Id, t.Pack_Id })
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCart_Id, cascadeDelete: true)
                .ForeignKey("dbo.Packs", t => t.Pack_Id, cascadeDelete: true)
                .Index(t => t.ShoppingCart_Id)
                .Index(t => t.Pack_Id);
            
            CreateTable(
                "dbo.ProductPacks",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Pack_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Pack_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Packs", t => t.Pack_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Pack_Id);
            
            CreateTable(
                "dbo.ProductShoppingCarts",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        ShoppingCart_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.ShoppingCart_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCart_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.ShoppingCart_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Stocks", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductShoppingCarts", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ProductShoppingCarts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductPacks", "Pack_Id", "dbo.Packs");
            DropForeignKey("dbo.ProductPacks", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ShoppingCartPacks", "Pack_Id", "dbo.Packs");
            DropForeignKey("dbo.ShoppingCartPacks", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropIndex("dbo.ProductShoppingCarts", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.ProductShoppingCarts", new[] { "Product_Id" });
            DropIndex("dbo.ProductPacks", new[] { "Pack_Id" });
            DropIndex("dbo.ProductPacks", new[] { "Product_Id" });
            DropIndex("dbo.ShoppingCartPacks", new[] { "Pack_Id" });
            DropIndex("dbo.ShoppingCartPacks", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.Stocks", new[] { "Store_Id" });
            DropIndex("dbo.Stocks", new[] { "Product_Id" });
            DropTable("dbo.ProductShoppingCarts");
            DropTable("dbo.ProductPacks");
            DropTable("dbo.ShoppingCartPacks");
            DropTable("dbo.Users");
            DropTable("dbo.Stores");
            DropTable("dbo.Reclamations");
            DropTable("dbo.Quotations");
            DropTable("dbo.Stocks");
            DropTable("dbo.Products");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.Packs");
            DropTable("dbo.Invoices");
            DropTable("dbo.Clients");
        }
    }
}
