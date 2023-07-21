using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.UI.Controllers
{
    public class PizzaPanHomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
