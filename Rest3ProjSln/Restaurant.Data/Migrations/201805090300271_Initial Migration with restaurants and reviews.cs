namespace Restaurant.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrationwithrestaurantsandreviews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Street1 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        phone = c.String(),
                        Zipcode = c.String(),
                        AvgRating = c.Int(),
                        Created = c.DateTime(),
                        Modified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating = c.Double(nullable: false),
                        Comments = c.String(maxLength: 200),
                        Created = c.DateTime(),
                        Modified = c.DateTime(),
                        RestaurantId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RestModels", t => t.RestaurantId_Id)
                .Index(t => t.RestaurantId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "RestaurantId_Id", "dbo.RestModels");
            DropIndex("dbo.Reviews", new[] { "RestaurantId_Id" });
            DropTable("dbo.Reviews");
            DropTable("dbo.RestModels");
        }
    }
}
