namespace WebApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.dataModels", "Class", c => c.String(maxLength: 60));
            AlterColumn("dbo.dataModels", "Field", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.dataModels", "Teacher", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.dataModels", "Venue", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.dataModels", "Venue", c => c.String());
            AlterColumn("dbo.dataModels", "Teacher", c => c.String());
            AlterColumn("dbo.dataModels", "Field", c => c.String());
            AlterColumn("dbo.dataModels", "Class", c => c.String());
        }
    }
}
