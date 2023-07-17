using Microsoft.AspNetCore.Http;

namespace PizzaPan.UI.Models
{
    public class ImageFileViewModel
    {
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
