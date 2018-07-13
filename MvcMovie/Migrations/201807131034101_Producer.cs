namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Producer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Producer", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Producer");
        }
    }
}
