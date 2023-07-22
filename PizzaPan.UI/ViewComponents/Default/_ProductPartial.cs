using Microsoft.AspNetCore.Mvc;
using PizzaPan.Business.Abstract;
using PizzaPan.Business.Concrete;
using PizzaPan.DataAccess.EntityFramework;

namespace PizzaPan.UI.ViewComponents.Default
{
    public class _ProductPartial : ViewComponent
    {
        private readonly IProductService _productService;
        public _ProductPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetList();
            return View(values);
        }
    }
}
