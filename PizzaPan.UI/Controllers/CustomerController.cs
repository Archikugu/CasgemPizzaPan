using Microsoft.AspNetCore.Mvc;
using PizzaPan.Business.Abstract;

namespace PizzaPan.UI.Controllers
{
    public class CustomerController : Controller
    {
        ITestimonialsService _testimonialsService;

        public CustomerController(ITestimonialsService testimonialsService)
        {
            _testimonialsService = testimonialsService;
        }

        public IActionResult Index()
        {
            var values = _testimonialsService.TGetList();
            return View(values);
        }
    }
}
