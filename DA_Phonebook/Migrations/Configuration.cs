namespace DA_Phonebook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DA_Phonebook.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DA_Phonebook.DB";
        }

        protected override void Seed(DA_Phonebook.DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
