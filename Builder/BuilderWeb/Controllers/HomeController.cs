using BuilderWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace BuilderWeb.Controllers
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

        [HttpPost]
        public async Task<IActionResult>  Index(IFormCollection form)
        {
            string activo = form["listadoAct"].ToString();
            activos act = new activos();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44362/Builder?activo=" + activo))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    act = JsonConvert.DeserializeObject<activos>(apiResponse);
                }
            }
            act.activo = activo;
            return View(act);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}