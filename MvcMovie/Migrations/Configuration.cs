namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    Director = "Mr. Hollywood Director",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "G",
                    Price = 7.99M,
                    SciFiVotes = 10,
                    FantasyVotes = 2
                },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     Director = "Mr. Hollywood Director",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "G",
                     Price = 8.99M,
                     SciFiVotes = 10,
                     FantasyVotes = 2
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     Director = "Mr. Hollywood Director",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "G",
                     Price = 9.99M,
                     SciFiVotes = 10,
                     FantasyVotes = 2
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   Director = "Mr. Hollywood Director",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = "G",
                   Price = 3.99M,
                   SciFiVotes = 10,
                   FantasyVotes = 2
               }
           );

        }   



    }
}
