namespace Chuong2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablestudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account Connect",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        Studentname = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Account Connect");
        }
    }
}
