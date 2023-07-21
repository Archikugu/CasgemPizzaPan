using Microsoft.AspNetCore.Mvc;
using PizzaPan.Business.Abstract;

namespace PizzaPan.UI.ViewComponents.Default
{
    public class _GalleryPartial : ViewComponent
    {
        private readonly IGalleryService _galleryService;

        public _GalleryPartial(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _galleryService.TGetList();
            return View(result);
        }
    }
}
