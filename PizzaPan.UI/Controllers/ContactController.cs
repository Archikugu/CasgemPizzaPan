using Microsoft.AspNetCore.Mvc;
using PizzaPan.Business.Abstract;
using PizzaPan.DataAccess.Concrete;
using PizzaPan.Entities.Concrete;

namespace PizzaPan.UI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact context)
        {
            _contactService.TInsert(context);
            return RedirectToAction("Index");
        }

        public IActionResult Details()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
    }
}
