using Microsoft.AspNetCore.Mvc;
using PizzaPan.Business.Abstract;

namespace PizzaPan.UI.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly ITestimonialsService _testimonialsService;

        public _TestimonialPartial(ITestimonialsService testimonialsService)
        {
            _testimonialsService = testimonialsService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialsService.TGetList();
            return View(values);
        }
    }
}
