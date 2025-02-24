using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace FilmeTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public MoviesController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchMovie(string title)
        {
            var apiKey = "xxxxxxxxxx"; // Coloque sua chave da OMDB API aqui
            var url = $"http://www.omdbapi.com/?apikey=[ea43b487]&";

            var response = await _httpClient.GetStringAsync(url);
            return Ok(response);
        }
    }
}