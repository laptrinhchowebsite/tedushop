namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newkey : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApplicationUsers", "BirthDay", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApplicationUsers", "BirthDay", c => c.DateTime(nullable: false));
        }
    }
}
