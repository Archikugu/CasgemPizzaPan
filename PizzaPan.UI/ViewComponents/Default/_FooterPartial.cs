using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.UI.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
