namespace sportsStore.Web.Migrations
{
    using sportsStore.Core;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<sportsStore.Web.Infrastructure.SportDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(sportsStore.Web.Infrastructure.SportDB context)
        {
            context.Sports.AddOrUpdate(d => d.Name,
                    new Sport() { Name = "Basketball" },
                    new Sport() { Name = "Football" },
                    new Sport() { Name = "Hockey" },
                    new Sport() { Name = "Baseball"}
                );
        }
    }
}
