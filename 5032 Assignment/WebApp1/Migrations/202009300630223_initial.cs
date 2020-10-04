namespace WebApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.dataModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Class = c.String(),
                        Date = c.DateTime(nullable: false),
                        Field = c.String(),
                        Fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Teacher = c.String(),
                        Venue = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.dataModels");
        }
    }
}
