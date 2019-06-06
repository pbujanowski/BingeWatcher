using BingeWatcher.Core.Models;
using BingeWatcher.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingeWatcher.Services
{
    public class MovieService : IMovieService
    {
        public async Task<List<Movie>> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> GetMovieById(int movieId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Movie>> GetMoviesByGenre(MovieGenre genre)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Movie>> GetMoviesBySearchText(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
