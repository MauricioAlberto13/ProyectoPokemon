using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View();
        }
    }
}
