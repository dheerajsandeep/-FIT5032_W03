namespace WebApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApp1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApp1.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApp1.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

                context.dataModels.AddOrUpdate(i=> i.Class,
                    new dataModel{
                        Class = "Guitar",
                        Date = DateTime.Parse("2020-11-13"),
                        Field = "Music",
                        Fee = 18,
                        Teacher ="Hendrix",
                        Venue = "St Kilda Library",
                        Rating = "Beginner"

            },
                        new dataModel
                        {
                            Class = "Piano",
                            Date = DateTime.Parse("2020-11-18"),
                            Field = "Music",
                            Fee = 22,
                            Teacher = "Bach J",
                            Venue = "St Kilda Library",
                            Rating = "Intermediate"

                        }

            );
        }
    }
}
