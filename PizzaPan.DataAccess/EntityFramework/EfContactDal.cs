using PizzaPan.DataAccess.Abstract;
using PizzaPan.DataAccess.Repositories;
using PizzaPan.Entities.Concrete;

namespace PizzaPan.DataAccess.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
    }
}
