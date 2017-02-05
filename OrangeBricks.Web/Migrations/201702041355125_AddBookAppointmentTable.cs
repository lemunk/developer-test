namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookAppointmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookAppointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        BuyerId = c.String(),
                        PropertyId = c.String(),
                        Accepted = c.Boolean(nullable: false),
                        Property_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Properties", t => t.Property_Id)
                .Index(t => t.Property_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookAppointments", "Property_Id", "dbo.Properties");
            DropIndex("dbo.BookAppointments", new[] { "Property_Id" });
            DropTable("dbo.BookAppointments");
        }
    }
}
