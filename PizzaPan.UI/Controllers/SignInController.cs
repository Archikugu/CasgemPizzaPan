using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.Entities.Concrete;
using PizzaPan.UI.Models;
using System.Threading.Tasks;

namespace PizzaPan.UI.Controllers
{
    public class SignInController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public SignInController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, true, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
