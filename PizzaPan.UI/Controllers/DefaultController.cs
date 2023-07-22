using Microsoft.AspNetCore.Mvc;
using PizzaPan.DataAccess.Concrete;

namespace PizzaPan.UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
