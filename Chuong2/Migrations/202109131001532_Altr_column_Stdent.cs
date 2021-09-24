namespace Chuong2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Altr_column_Stdent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Studentname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Studentname", c => c.String());
            DropColumn("dbo.Students", "Address");
        }
    }
}
