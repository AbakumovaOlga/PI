namespace PI_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myFirstMigr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaterialBuys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        MaterialId = c.Int(nullable: false),
                        BuyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buys", t => t.BuyId, cascadeDelete: true)
                .ForeignKey("dbo.Materials", t => t.MaterialId, cascadeDelete: true)
                .Index(t => t.MaterialId)
                .Index(t => t.BuyId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        SizeId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Typemy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sizes", t => t.SizeId, cascadeDelete: true)
                .ForeignKey("dbo.Typemies", t => t.Typemy_Id)
                .Index(t => t.SizeId)
                .Index(t => t.Typemy_Id);
            
            CreateTable(
                "dbo.MaterialOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaterialId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.MaterialId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.MaterialId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Summa = c.Double(nullable: false),
                        Customer = c.String(),
                        UserId = c.Int(),
                        DateCreate = c.DateTime(nullable: false),
                        DateFinish = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Typemies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "Typemy_Id", "dbo.Typemies");
            DropForeignKey("dbo.Materials", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.MaterialOrders", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.MaterialOrders", "MaterialId", "dbo.Materials");
            DropForeignKey("dbo.MaterialBuys", "MaterialId", "dbo.Materials");
            DropForeignKey("dbo.MaterialBuys", "BuyId", "dbo.Buys");
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.MaterialOrders", new[] { "OrderId" });
            DropIndex("dbo.MaterialOrders", new[] { "MaterialId" });
            DropIndex("dbo.Materials", new[] { "Typemy_Id" });
            DropIndex("dbo.Materials", new[] { "SizeId" });
            DropIndex("dbo.MaterialBuys", new[] { "BuyId" });
            DropIndex("dbo.MaterialBuys", new[] { "MaterialId" });
            DropTable("dbo.Typemies");
            DropTable("dbo.Sizes");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.MaterialOrders");
            DropTable("dbo.Materials");
            DropTable("dbo.MaterialBuys");
            DropTable("dbo.Buys");
        }
    }
}
