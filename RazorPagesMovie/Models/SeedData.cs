using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new RazorPagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Batman",
                        DateReleased = DateTime.Parse("2022-3-4"),
                        Genre = "Action Crime Drama",
                        Price = 50_000M, 
                        Rating = "R"
                    }, new Movie
                    {
                        Title = "The Joker",
                        DateReleased = DateTime.Parse("2019-10-4"),
                        Genre = "Action Crime Drama",
                        Price = 50_000M, 
                        Rating = "R"
                    }, new Movie
                    {
                        Title = "The Greatest Showman",
                        DateReleased = DateTime.Parse("2017-12-7"),
                        Genre = "Biography Musical Drama",
                        Price = 40_000M, 
                        Rating = "PG-13"
                    }, new Movie
                    {
                        Title = "Free Guy",
                        DateReleased = DateTime.Parse("2021-8-13"),
                        Genre = "Action Adventure Comedy",
                        Price = 45_000M, 
                        Rating = "PG-13"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
