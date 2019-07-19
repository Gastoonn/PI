namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShoppingCartPacks", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCartPacks", "Pack_Id", "dbo.Packs");
            DropForeignKey("dbo.ProductShoppingCarts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductShoppingCarts", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropIndex("dbo.ShoppingCartPacks", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.ShoppingCartPacks", new[] { "Pack_Id" });
            DropIndex("dbo.ProductShoppingCarts", new[] { "Product_Id" });
            DropIndex("dbo.ProductShoppingCarts", new[] { "ShoppingCart_Id" });
            AddColumn("dbo.ShoppingCarts", "idProduct", c => c.Int(nullable: false));
            AddColumn("dbo.ShoppingCarts", "Quantite", c => c.Int(nullable: false));
            AddColumn("dbo.ShoppingCarts", "IsAPack", c => c.Boolean(nullable: false));
            AddColumn("dbo.ShoppingCarts", "Pack_Id", c => c.Int());
            AddColumn("dbo.ShoppingCarts", "Product_Id", c => c.Int());
            CreateIndex("dbo.ShoppingCarts", "Pack_Id");
            CreateIndex("dbo.ShoppingCarts", "Product_Id");
            AddForeignKey("dbo.ShoppingCarts", "Pack_Id", "dbo.Packs", "Id");
            AddForeignKey("dbo.ShoppingCarts", "Product_Id", "dbo.Products", "Id");
            DropTable("dbo.ShoppingCartPacks");
            DropTable("dbo.ProductShoppingCarts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductShoppingCarts",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        ShoppingCart_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.ShoppingCart_Id });
            
            CreateTable(
                "dbo.ShoppingCartPacks",
                c => new
                    {
                        ShoppingCart_Id = c.Int(nullable: false),
                        Pack_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingCart_Id, t.Pack_Id });
            
            DropForeignKey("dbo.ShoppingCarts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ShoppingCarts", "Pack_Id", "dbo.Packs");
            DropIndex("dbo.ShoppingCarts", new[] { "Product_Id" });
            DropIndex("dbo.ShoppingCarts", new[] { "Pack_Id" });
            DropColumn("dbo.ShoppingCarts", "Product_Id");
            DropColumn("dbo.ShoppingCarts", "Pack_Id");
            DropColumn("dbo.ShoppingCarts", "IsAPack");
            DropColumn("dbo.ShoppingCarts", "Quantite");
            DropColumn("dbo.ShoppingCarts", "idProduct");
            CreateIndex("dbo.ProductShoppingCarts", "ShoppingCart_Id");
            CreateIndex("dbo.ProductShoppingCarts", "Product_Id");
            CreateIndex("dbo.ShoppingCartPacks", "Pack_Id");
            CreateIndex("dbo.ShoppingCartPacks", "ShoppingCart_Id");
            AddForeignKey("dbo.ProductShoppingCarts", "ShoppingCart_Id", "dbo.ShoppingCarts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductShoppingCarts", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ShoppingCartPacks", "Pack_Id", "dbo.Packs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ShoppingCartPacks", "ShoppingCart_Id", "dbo.ShoppingCarts", "Id", cascadeDelete: true);
        }
    }
}
