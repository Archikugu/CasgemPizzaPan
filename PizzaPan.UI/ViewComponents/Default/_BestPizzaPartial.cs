using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.UI.ViewComponents.Default
{
    public class _BestPizzaPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
