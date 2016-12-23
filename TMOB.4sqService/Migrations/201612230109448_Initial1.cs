namespace TMOB._4sqService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SearchVenues",
                c => new
                    {
                        searchKeyword = c.String(nullable: false, maxLength: 128),
                        city = c.String(),
                        Location_Latitude = c.Double(nullable: false),
                        Location_Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.searchKeyword);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SearchVenues");
        }
    }
}
