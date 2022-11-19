namespace DA_Phonebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class available : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Phonebooks", "available", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Phonebooks", "available");
        }
    }
}
