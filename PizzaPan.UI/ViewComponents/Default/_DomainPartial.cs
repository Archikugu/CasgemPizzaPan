using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.UI.ViewComponents.Default
{
    public class _DomainPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
