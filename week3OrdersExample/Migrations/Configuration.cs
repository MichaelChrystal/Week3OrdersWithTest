namespace week3OrdersExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestingOrderExample.Models.BusinessDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\";
        }

        protected override void Seed(TestingOrderExample.Models.BusinessDBContext context)
        {//TestingOrderExample.Models.BusinessDBContext context

            SeedProducts(context);
            SeedCustomers(context);

            base.Seed(context);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
