namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookAppointment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookAppointments", "Property_Id", "dbo.Properties");
            DropIndex("dbo.BookAppointments", new[] { "Property_Id" });
            DropColumn("dbo.BookAppointments", "PropertyId");
            RenameColumn(table: "dbo.BookAppointments", name: "Property_Id", newName: "PropertyId");
            AlterColumn("dbo.BookAppointments", "PropertyId", c => c.Int(nullable: false));
            AlterColumn("dbo.BookAppointments", "PropertyId", c => c.Int(nullable: false));
            CreateIndex("dbo.BookAppointments", "PropertyId");
            AddForeignKey("dbo.BookAppointments", "PropertyId", "dbo.Properties", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookAppointments", "PropertyId", "dbo.Properties");
            DropIndex("dbo.BookAppointments", new[] { "PropertyId" });
            AlterColumn("dbo.BookAppointments", "PropertyId", c => c.Int());
            AlterColumn("dbo.BookAppointments", "PropertyId", c => c.String());
            RenameColumn(table: "dbo.BookAppointments", name: "PropertyId", newName: "Property_Id");
            AddColumn("dbo.BookAppointments", "PropertyId", c => c.String());
            CreateIndex("dbo.BookAppointments", "Property_Id");
            AddForeignKey("dbo.BookAppointments", "Property_Id", "dbo.Properties", "Id");
        }
    }
}
