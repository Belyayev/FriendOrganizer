namespace FriendOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Model.Friend { FirstName = "From", LastName = "Database", Email = "db@db.com" },
                new Model.Friend { FirstName = "Mike", LastName = "Belyayev", Email = "db@db.com" },
                new Model.Friend { FirstName = "Ramon", LastName = "Sanches", Email = "ramon@gmail.com" },
                new Model.Friend { FirstName = "Felix", LastName = "Edmondovich", Email = "db@db.com" }
                );
        }
    }
}
