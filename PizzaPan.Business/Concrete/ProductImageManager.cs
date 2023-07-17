using PizzaPan.Business.Abstract;
using PizzaPan.DataAccess.Abstract;
using PizzaPan.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.Business.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        private readonly IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }
        public void TInsert(ProductImage t)
        {
            _productImageDal.Insert(t);
        }
        public void TUpdate(ProductImage t)
        {
            _productImageDal.Update(t);
        }
        public void TDelete(ProductImage t)
        {
            _productImageDal.Delete(t);
        }

        public ProductImage TGetByID(int id)
        {
            return _productImageDal.GetByID(id);
        }
        public List<ProductImage> TGetList()
        {
            return _productImageDal.GetList();
        }


    }
}
