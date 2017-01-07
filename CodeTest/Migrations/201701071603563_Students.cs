namespace CodeTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Students : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 80),
                        StudentSurname = c.String(nullable: false, maxLength: 80),
                        DOB = c.DateTime(nullable: false),
                        GPA = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
        }
    }
}
