namespace UsedVehicleSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validations : DbMigration
    {
        public override void Up()
        {
            ////CreateTable(
            ////    "dbo.Ads",
            ////    c => new
            ////        {
            ////            ID = c.Int(nullable: false, identity: true),
            ////            UserID = c.String(),
            ////            AdTitle = c.String(),
            ////            AdCategory = c.String(),
            ////        })
            ////    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Bikes",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            title = c.String(nullable: false),
            //            model = c.String(nullable: false),
            //            make = c.String(nullable: false),
            //            estimatedPrice = c.Single(nullable: false),
            //            documents = c.Boolean(nullable: false),
            //            condition = c.Boolean(nullable: false),
            //            imageUrl = c.String(nullable: false),
            //            userID = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Cars",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            title = c.String(nullable: false),
            //            model = c.String(nullable: false),
            //            make = c.String(nullable: false),
            //            estimatedPrice = c.Single(nullable: false),
            //            drivenInKms = c.Single(nullable: false),
            //            documents = c.Boolean(nullable: false),
            //            condition = c.Boolean(nullable: false),
            //            Image = c.Byte(nullable: false),
            //            imageUrl = c.String(nullable: false),
            //            userID = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.MotorBikes",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            title = c.String(nullable: false),
            //            model = c.String(nullable: false),
            //            make = c.String(nullable: false),
            //            estimatedPrice = c.Single(nullable: false),
            //            drivenInKms = c.Single(nullable: false),
            //            documents = c.Boolean(nullable: false),
            //            condition = c.Boolean(nullable: false),
            //            imageUrl = c.String(nullable: false),
            //            userID = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.OfficeLocations",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Address = c.String(),
            //            StateOrProvince = c.String(),
            //            CityName = c.String(),
            //            ZipCode = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Users",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false),
            //            PhoneNumber = c.String(nullable: false),
            //            Email = c.String(nullable: false),
            //            Address = c.String(),
            //            StateOrProvince = c.String(),
            //            CityName = c.String(),
            //            ZipCode = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.OfficeLocations");
            DropTable("dbo.MotorBikes");
            DropTable("dbo.Cars");
            DropTable("dbo.Bikes");
            DropTable("dbo.Ads");
        }
    }
}
