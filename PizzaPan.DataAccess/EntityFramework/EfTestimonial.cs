using PizzaPan.DataAccess.Abstract;
using PizzaPan.DataAccess.Repositories;
using PizzaPan.Entities.Concrete;

namespace PizzaPan.DataAccess.EntityFramework
{
    public class EfTestimonial : GenericRepository<Testimonial>, ITestimonialDal
    {
    }
}
