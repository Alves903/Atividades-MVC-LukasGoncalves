using Microsoft.AspNetCore.Mvc;

namespace RestauranteMVC.Controllers
{
    public class RestauranteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cardapio()
        {
            return View();
        }

        public IActionResult Bebidas()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}
