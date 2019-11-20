namespace CrossTask2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "CityId");
            AddForeignKey("dbo.Employees", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "CityId", "dbo.Cities");
            DropIndex("dbo.Employees", new[] { "CityId" });
            DropColumn("dbo.Employees", "CityId");
            DropTable("dbo.Cities");
        }
    }
}
