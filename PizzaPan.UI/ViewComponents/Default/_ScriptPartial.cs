using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.UI.ViewComponents.Default
{
    public class _ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
