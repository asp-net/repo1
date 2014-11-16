namespace Migration.Migrations
{
	using Migration.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Migration.Models.AppDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Migration.Models.AppDB context)
        {
			var items = new Phone[] { 
				new Phone() {Id = 1, Brand = "Apple", Name = "iPhone 5"},
				new Phone() { Id = 2, Brand = "LG", Name = "Nexus 4" }
			};

			context.Phones.AddOrUpdate(p => p.Id, items);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
