using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?checkout_date=2026-01-28&filter_by_currency=EUR&order_by=popularity&dest_id=-1456928&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&locale=en-gb&dest_type=city&units=metric&include_adjacency=true&children_number=2&room_number=1&adults_number=2&page_number=0&checkin_date=2026-01-27"),
                Headers =
{
   { "x-rapidapi-key", "bee51651fdmshbbc375389ee61b2p180f6djsn683e69404831" },
   { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
},
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var bodyReplace = body.Replace(".", "");
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
                return View(values.results);
            }
        }

        [HttpGet]
        public IActionResult GetCityDestID()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCityDestID(string p)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?checkout_date=2026-01-28&filter_by_currency=EUR&order_by=popularity&dest_id=-1456928&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&locale=en-gb&dest_type=city&units=metric&include_adjacency=true&children_number=2&room_number=1&adults_number=2&page_number=0&checkin_date=2026-01-27"),
                Headers =
{
   { "x-rapidapi-key", "bee51651fdmshbbc375389ee61b2p180f6djsn683e69404831" },
   { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
},
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }
    }
}