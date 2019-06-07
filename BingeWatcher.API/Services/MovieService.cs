using BingeWatcher.API.Data;
using BingeWatcher.Core.Models;
using BingeWatcher.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BingeWatcher.API.Services
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext context;

        public MovieService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            return await Task.FromResult(context.Movies.ToList()).ConfigureAwait(false);
        }

        public async Task<Movie> GetMovieById(int movieId)
        {
            return await Task.FromResult(context.Movies.Where(m => m.Id == movieId).SingleOrDefault()).ConfigureAwait(false);
        }

        public async Task<List<Movie>> GetMoviesByGenre(MovieGenre genre)
        {
            return await Task.FromResult(context.Movies.Where(m => m.Genre == genre).ToList()).ConfigureAwait(false);
        }

        public async Task<List<Movie>> GetMoviesBySearchText(string searchText)
        {
            return await Task.FromResult(context.Movies.Where(m => m.Title.Contains(searchText)).ToList()).ConfigureAwait(false);
        }
    }
}
