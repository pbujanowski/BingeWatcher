using BingeWatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BingeWatcher.Core.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMovies();

        Task<List<Movie>> GetMoviesBySearchText(string searchText);

        Task<Movie> GetMovieById(int movieId);

        Task<List<Movie>> GetMoviesByGenre(MovieGenre genre);
    }
}
