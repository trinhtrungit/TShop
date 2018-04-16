namespace TShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailOrders",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.ProductId })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);

            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 100),
                        CustomerMobile = c.String(nullable: false, maxLength: 15, unicode: false),
                        CustomerEmail = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerMessages = c.String(maxLength: 300),
                        CustomerAddress = c.String(nullable: false, maxLength: 500),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 100),
                        Status = c.Int(nullable: false),
                        PaymentMethod = c.String(maxLength: 100),
                        PaymentStatus = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                        Alias = c.String(nullable: false, maxLength: 300, unicode: false),
                        Image = c.String(nullable: false, maxLength: 300),
                        MoreImages = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Promotion = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(),
                        Varranty = c.Int(),
                        ProductContent = c.String(),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        HotFlag = c.Boolean(),
                        HomeFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 400),
                        MetaDescription = c.String(maxLength: 400),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);

            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                        Alias = c.String(nullable: false, maxLength: 300, unicode: false),
                        FeatureImage = c.String(nullable: false, maxLength: 300),
                        ParentId = c.Int(),
                        DisplayOrder = c.Int(),
                        HomeFlag = c.Int(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 400),
                        MetaDescription = c.String(maxLength: 400),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        FooterContent = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.GroupMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                        GroupId = c.Int(nullable: false),
                        Url = c.String(maxLength: 300),
                        Target = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GroupMenus", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);

            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 300),
                        PageContent = c.String(),
                        MetaKeyword = c.String(maxLength: 400),
                        MetaDescription = c.String(maxLength: 400),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                        Alias = c.String(nullable: false, maxLength: 300, unicode: false),
                        FeatureImage = c.String(nullable: false, maxLength: 300),
                        ParentId = c.Int(),
                        DisplayOrder = c.Int(),
                        HomeFlag = c.Int(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 400),
                        MetaDescription = c.String(maxLength: 400),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                        Alias = c.String(nullable: false, maxLength: 300, unicode: false),
                        FeatureImage = c.String(nullable: false, maxLength: 300),
                        PostContent = c.String(),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 400),
                        MetaDescription = c.String(maxLength: 400),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);

            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        TagId = c.String(nullable: false, maxLength: 50, unicode: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TagId, t.PostId })
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.PostId);

            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        TagName = c.String(),
                        TagType = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        TagId = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TagId, t.ProductId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.ProductId);

            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Image = c.String(nullable: false, maxLength: 300),
                        Url = c.String(nullable: false, maxLength: 300),
                        Description = c.String(),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 100, unicode: false),
                        Mobile = c.String(maxLength: 15, unicode: false),
                        Address = c.String(),
                        Facebook = c.String(maxLength: 256),
                        Department = c.String(maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 256, unicode: false),
                        ValueString = c.String(maxLength: 256),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        IPAddress = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductId", "dbo.Products");
            DropForeignKey("dbo.PostTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.PostCategories");
            DropForeignKey("dbo.Menus", "GroupId", "dbo.GroupMenus");
            DropForeignKey("dbo.DetailOrders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.DetailOrders", "OrderId", "dbo.Orders");
            DropIndex("dbo.ProductTags", new[] { "ProductId" });
            DropIndex("dbo.ProductTags", new[] { "TagId" });
            DropIndex("dbo.PostTags", new[] { "PostId" });
            DropIndex("dbo.PostTags", new[] { "TagId" });
            DropIndex("dbo.Posts", new[] { "CategoryId" });
            DropIndex("dbo.Menus", new[] { "GroupId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.DetailOrders", new[] { "ProductId" });
            DropIndex("dbo.DetailOrders", new[] { "OrderId" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Sliders");
            DropTable("dbo.ProductTags");
            DropTable("dbo.Tags");
            DropTable("dbo.PostTags");
            DropTable("dbo.Posts");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Pages");
            DropTable("dbo.Menus");
            DropTable("dbo.GroupMenus");
            DropTable("dbo.Footers");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.DetailOrders");
        }
    }
}