namespace ReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataanotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Comment", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Comment", c => c.String());
        }
    }
}
