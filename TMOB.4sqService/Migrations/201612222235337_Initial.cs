namespace TMOB._4sqService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Transactions");
            AlterColumn("dbo.Transactions", "ApplicationVersion", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Transactions", "ApplicationVersion");
            DropColumn("dbo.Transactions", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Transactions");
            AlterColumn("dbo.Transactions", "ApplicationVersion", c => c.String());
            AddPrimaryKey("dbo.Transactions", "ID");
        }
    }
}
