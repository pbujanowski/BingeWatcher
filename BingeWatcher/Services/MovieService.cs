using BingeWatcher.Core.Models;
using BingeWatcher.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace BingeWatcher.Services
{
    public class MovieService : IMovieService
    {
        public async Task<List<Movie>> GetAllMovies()
        {
            Uri uri = new Uri(HttpUrls.MOVIE_GET_ALL);
            using (var httpClient = new HttpClient())
            using (var response = await httpClient.GetAsync(uri))
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Movie>>(result);
                }
                else
                {
                    throw new Exception("Nie udało się pobrać listy filmów!");
                }
        }

        public async Task<Movie> GetMovieById(int movieId)
        {
            Uri uri = new Uri(HttpUrls.MOVIE_GET_BY_ID);
            using (var httpClient = new HttpClient())
            using (var response = await httpClient.GetAsync(uri))
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Movie>(result);
                }
                else
                {
                    throw new Exception("Nie udało się pobrać filmu!");
                }
        }

        public async Task<List<Movie>> GetMoviesByGenre(MovieGenre genre)
        {
            Uri uri = new Uri(HttpUrls.MOVIE_GET_BY_GENERE);
            using (var httpClient = new HttpClient())
            using (var response = await httpClient.GetAsync(uri))
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Movie>>(result);
                }
                else
                {
                    throw new Exception("Nie udało się pobrać listy filmów!");
                }
        }

        public async Task<List<Movie>> GetMoviesBySearchText(string searchText)
        {
            Uri uri = new Uri(HttpUrls.MOVIE_GET_BY_SEARCH);
            using (var httpClient = new HttpClient())
            using (var response = await httpClient.GetAsync(uri))
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Movie>>(result);
                }
                else
                {
                    throw new Exception("Nie udało się pobrać listy filmów!");
                }
        }
    }
}
