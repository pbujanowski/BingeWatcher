using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BingeWatcher.Core.Models;

namespace BingeWatcher.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Film akcji nr 1", Genre = MovieGenre.Action, Director = "Reżyser kina akcji" },
                new Movie { Id = 2, Title = "Film akcji nr 2", Genre = MovieGenre.Action, Director = "Reżyser kina akcji" },
                new Movie { Id = 3, Title = "Film akcji nr 3", Genre = MovieGenre.Action, Director = "Reżyser kina akcji" },

                new Movie { Id = 4, Title = "Film przygodowy nr 1", Genre = MovieGenre.Adventure, Director = "Reżyser kina przygodowego" },
                new Movie { Id = 5, Title = "Film przygodowy nr 2", Genre = MovieGenre.Adventure, Director = "Reżyser kina przygodowego" },
                new Movie { Id = 6, Title = "Film przygodowy nr 3", Genre = MovieGenre.Adventure, Director = "Reżyser kina przygodowego" },

                new Movie { Id = 7, Title = "Film komediowy nr 1", Genre = MovieGenre.Comedy, Director = "Reżyser kina komediowego" },
                new Movie { Id = 8, Title = "Film komediowy nr 2", Genre = MovieGenre.Comedy, Director = "Reżyser kina komediowego" },
                new Movie { Id = 9, Title = "Film komediowy nr 3", Genre = MovieGenre.Comedy, Director = "Reżyser kina komediowego" },

                new Movie { Id = 10, Title = "Film kryminalny nr 1", Genre = MovieGenre.Crime, Director = "Reżyser kina kryminalnego" },
                new Movie { Id = 11, Title = "Film kryminalny nr 2", Genre = MovieGenre.Crime, Director = "Reżyser kina kryminalnego" },
                new Movie { Id = 12, Title = "Film kryminalny nr 3", Genre = MovieGenre.Crime, Director = "Reżyser kina kryminalnego" },

                new Movie { Id = 13, Title = "Film dramatyczny nr 1", Genre = MovieGenre.Drama, Director = "Reżyser kina dramatycznego" },
                new Movie { Id = 14, Title = "Film dramatyczny nr 2", Genre = MovieGenre.Drama, Director = "Reżyser kina dramatycznego" },
                new Movie { Id = 15, Title = "Film dramatyczny nr 3", Genre = MovieGenre.Drama, Director = "Reżyser kina dramatycznego" },

                new Movie { Id = 16, Title = "Film fantasy nr 1", Genre = MovieGenre.Fantasy, Director = "Reżyser kina fantasy" },
                new Movie { Id = 17, Title = "Film fantasy nr 2", Genre = MovieGenre.Fantasy, Director = "Reżyser kina fantasy" },
                new Movie { Id = 18, Title = "Film fantasy nr 3", Genre = MovieGenre.Fantasy, Director = "Reżyser kina fantasy" },

                new Movie { Id = 19, Title = "Film historyczny nr 1", Genre = MovieGenre.Historical, Director = "Reżyser kina historycznego" },
                new Movie { Id = 20, Title = "Film historyczny nr 2", Genre = MovieGenre.Historical, Director = "Reżyser kina historycznego" },
                new Movie { Id = 21, Title = "Film historyczny nr 3", Genre = MovieGenre.Historical, Director = "Reżyser kina historycznego" },

                new Movie { Id = 22, Title = "Film horror nr 1", Genre = MovieGenre.Horror, Director = "Reżyser kina horror" },
                new Movie { Id = 23, Title = "Film horror nr 2", Genre = MovieGenre.Horror, Director = "Reżyser kina horror" },
                new Movie { Id = 24, Title = "Film horror nr 3", Genre = MovieGenre.Horror, Director = "Reżyser kina horror" },

                new Movie { Id = 25, Title = "Film polityczny nr 1", Genre = MovieGenre.Political, Director = "Reżyser kina politycznego" },
                new Movie { Id = 26, Title = "Film polityczny nr 2", Genre = MovieGenre.Political, Director = "Reżyser kina politycznego" },
                new Movie { Id = 27, Title = "Film polityczny nr 3", Genre = MovieGenre.Political, Director = "Reżyser kina politycznego" },

                new Movie { Id = 28, Title = "Film romantyczny nr 1", Genre = MovieGenre.Romance, Director = "Reżyser kina romantycznego" },
                new Movie { Id = 29, Title = "Film romantyczny nr 2", Genre = MovieGenre.Romance, Director = "Reżyser kina romantycznego" },
                new Movie { Id = 30, Title = "Film romantyczny nr 3", Genre = MovieGenre.Romance, Director = "Reżyser kina romantycznego" },

                new Movie { Id = 31, Title = "Film science fiction nr 1", Genre = MovieGenre.ScienceFiction, Director = "Reżyser kina science fiction" },
                new Movie { Id = 32, Title = "Film science fiction nr 2", Genre = MovieGenre.ScienceFiction, Director = "Reżyser kina science fiction" },
                new Movie { Id = 33, Title = "Film science fiction nr 3", Genre = MovieGenre.ScienceFiction, Director = "Reżyser kina science fiction" },

                new Movie { Id = 34, Title = "Film dreszczowiec nr 1", Genre = MovieGenre.Thriller, Director = "Reżyser kina dreszczowców" },
                new Movie { Id = 35, Title = "Film dreszczowiec nr 2", Genre = MovieGenre.Thriller, Director = "Reżyser kina dreszczowców" },
                new Movie { Id = 36, Title = "Film dreszczowiec nr 3", Genre = MovieGenre.Thriller, Director = "Reżyser kina dreszczowców" },

                new Movie { Id = 37, Title = "Film western nr 1", Genre = MovieGenre.Western, Director = "Reżyser kina western" },
                new Movie { Id = 38, Title = "Film western nr 2", Genre = MovieGenre.Western, Director = "Reżyser kina western" },
                new Movie { Id = 39, Title = "Film western nr 3", Genre = MovieGenre.Western, Director = "Reżyser kina western" },

                new Movie { Id = 40, Title = "Film musical nr 1", Genre = MovieGenre.Musical, Director = "Reżyser kina musical" },
                new Movie { Id = 41, Title = "Film musical nr 2", Genre = MovieGenre.Musical, Director = "Reżyser kina musical" },
                new Movie { Id = 42, Title = "Film musical nr 3", Genre = MovieGenre.Musical, Director = "Reżyser kina musical" },

                new Movie { Id = 43, Title = "Film anime nr 1", Genre = MovieGenre.Anime, Director = "Reżyser kina anime" },
                new Movie { Id = 44, Title = "Film anime nr 2", Genre = MovieGenre.Anime, Director = "Reżyser kina anime" },
                new Movie { Id = 45, Title = "Film anime nr 3", Genre = MovieGenre.Anime, Director = "Reżyser kina anime" }
                );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Jan", LastName = "Kowalski", UserName = "jkowalski" },
                new User { Id = 2, FirstName = "Janina", LastName = "Kowalska", UserName = "jkowalska" });
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
