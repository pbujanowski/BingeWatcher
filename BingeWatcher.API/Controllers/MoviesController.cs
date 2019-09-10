using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BingeWatcher.Core.Models;
using BingeWatcher.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BingeWatcher.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService movieService;

        // GET: api/Movies
        [HttpGet]
        [Authorize]
        public async Task<string> GetAllMovies()
        {
            var movies = await movieService.GetAllMovies().ConfigureAwait(false);
            return JsonConvert.SerializeObject(movies);
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Get")]
        [Authorize]
        public async Task<string> GetMovieById(int id)
        {
            var movie = await movieService.GetMovieById(id).ConfigureAwait(false);
            return JsonConvert.SerializeObject(movie);
        }

        [HttpGet("{movieGenre}", Name = "Get")]
        public async Task<string> GetMoviesByGenre(MovieGenre movieGenre)
        {
            var movies = await movieService.GetMoviesByGenre(movieGenre).ConfigureAwait(false);
            return JsonConvert.SerializeObject(movies);
        }

        [HttpGet("{searchText}", Name = "Get")]
        public async Task<string> GetMoviesBySearchText(string searchText)
        {
            var movies = await movieService.GetMoviesBySearchText(searchText).ConfigureAwait(false);
            return JsonConvert.SerializeObject(movies);
        }

        public MoviesController(IMovieService movieService)
        {
            this.movieService = movieService;
        }
    }
}
