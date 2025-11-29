using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApiMovieController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ApiMovieController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("x-rapidapi-key", "bee51651fdmshbbc375389ee61b2p180f6djsn683e69404831");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com");

            var response = await client.GetAsync("https://imdb-top-100-movies.p.rapidapi.com/");

            if (!response.IsSuccessStatusCode)
                return View(new List<ApiMovieViewModel>());

            var json = await response.Content.ReadAsStringAsync();
            var movies = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(json);

            return View(movies);
        }
    }
}
