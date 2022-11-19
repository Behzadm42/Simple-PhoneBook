namespace DA_Phonebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phonebooks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        number = c.String(),
                        address = c.String(),
                        note = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phonebooks");
        }
    }
}
