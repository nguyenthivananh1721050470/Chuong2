namespace Chuong2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
