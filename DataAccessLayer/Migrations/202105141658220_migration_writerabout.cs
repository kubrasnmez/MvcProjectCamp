namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_writerabout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20));
            DropColumn("dbo.Writers", "WriterAbout");
        }
    }
}
