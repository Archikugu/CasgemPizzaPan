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
    public class GalleryManager : IGalleryService
    {
        private readonly IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void TInsert(Gallery t)
        {
            _galleryDal.Insert(t);
        }

        public void TUpdate(Gallery t)
        {
            _galleryDal.Update(t);
        }
        public void TDelete(Gallery t)
        {
            _galleryDal.Delete(t);
        }

        public Gallery TGetByID(int id)
        {
            return _galleryDal.GetByID(id);
        }

        public List<Gallery> TGetList()
        {
            return _galleryDal.GetList();
        }
    }
}
