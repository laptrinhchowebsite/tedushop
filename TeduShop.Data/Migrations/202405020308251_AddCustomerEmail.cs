﻿namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CustomerEmail", c => c.String(nullable: false, maxLength: 256));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "CustomerEmail");
        }
    }
}
