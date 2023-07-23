using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.UI.ViewComponents.Default
{
    public class _EatPizzaEveryDayPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
