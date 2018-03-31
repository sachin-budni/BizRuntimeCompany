namespace CodeEntityMap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address1", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student1", "Address_Id", "dbo.Address1");
            DropIndex("dbo.Student1", new[] { "Address_Id" });
            DropTable("dbo.Student1");
            DropTable("dbo.Address1");
        }
    }
}
