namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAppointmentField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookAppointments", "BookAppointmentDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookAppointments", "BookAppointmentDate");
        }
    }
}
