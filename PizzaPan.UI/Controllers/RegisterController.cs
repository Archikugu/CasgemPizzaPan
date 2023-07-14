using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.Entities.Concrete;
using PizzaPan.UI.Models;
using System.Threading.Tasks;

namespace PizzaPan.UI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = registerViewModel.Name,
                    Surname = registerViewModel.Surname,
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Username
                };
                await _userManager.CreateAsync(appUser, registerViewModel.Password);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }
    }
}
