namespace PageInspectorExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PageInspectorExample.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PageInspectorExample.Models.ApplicationDbContext context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Models.Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
                new Models.Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
                new Models.Restaurant { Name = "Smaka", City = "Gothenburg", Country = "Sweden" }
                );

            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Models.Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
            }
        }
    }
}
