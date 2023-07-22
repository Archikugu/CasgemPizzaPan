using Microsoft.AspNetCore.Mvc;
using PizzaPan.Business.Abstract;

namespace PizzaPan.UI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public AboutController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            var values = _ourTeamService.TGetList();
            return View(values);
        }
    }
}
