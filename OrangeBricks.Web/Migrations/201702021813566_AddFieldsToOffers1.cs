namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsToOffers1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "BuyerUserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offers", "BuyerUserId");
        }
    }
}
