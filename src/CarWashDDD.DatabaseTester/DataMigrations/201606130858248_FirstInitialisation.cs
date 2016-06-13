namespace CarWashDDD.DatabaseTester.DataMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstInitialisation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consumers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        PlateNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OpeningHours",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SlotCount = c.Int(nullable: false),
                        Weekday = c.Int(nullable: false),
                        ServiceProviderId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ReservedDateUtc = c.DateTime(nullable: false),
                        ConsumerId = c.String(nullable: false),
                        PlateNumber = c.String(nullable: false),
                        ServiceId = c.Guid(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceProviders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        SlotCount = c.Int(nullable: false),
                        ServiceProviderId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
            DropTable("dbo.ServiceProviders");
            DropTable("dbo.Reservations");
            DropTable("dbo.OpeningHours");
            DropTable("dbo.Consumers");
        }
    }
}
