using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using PizzaPan.Entities.Concrete;
using PizzaPan.UI.Models;
using System;
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
            Random rnd = new Random();
            int x = rnd.Next(100000, 1000000);

            AppUser appUser = new AppUser()
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Username,
                ConfirimCode = x

            };
            var result = await _userManager.CreateAsync(appUser, registerViewModel.Password);
            if (result.Succeeded)
            {
                #region
                SendMail(registerViewModel, x);
                #endregion

                TempData["Username"] = appUser.UserName;
                return RedirectToAction("Index", "ConfirmMail");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();

        }
        private static void SendMail(RegisterViewModel registerViewModel, int x)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "engokhangok@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", registerViewModel.Email);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Giriş Yapabilmek İçin Onay Kodunuz: " + x;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Doğrulama Kodu:";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("engokhangok@gmail.com", "ehhijhfqtwcgoaab");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
        }
    }
}
