using Microsoft.AspNetCore.Mvc;
using MvcMusicStore.Models;
using System.Diagnostics;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page";
            return View();
        }

        public IActionResult List()
        {
            var albums = new List<Album>();
            Random random = new();
            for (int i = 0; i < 10; ++i)
            {
                albums.Add(new Album { Title = $"Album {random.Next()}" });
            }
            return View(albums);
        }
        public IActionResult Edit()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}