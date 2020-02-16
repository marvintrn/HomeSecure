namespace HomeSecure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialisation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Detectors",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        RoomId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Moves",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        DetectorId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Detectors", t => t.DetectorId, cascadeDelete: true)
                .Index(t => t.DetectorId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detectors", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Moves", "DetectorId", "dbo.Detectors");
            DropIndex("dbo.Moves", new[] { "DetectorId" });
            DropIndex("dbo.Detectors", new[] { "RoomId" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Moves");
            DropTable("dbo.Detectors");
        }
    }
}
