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
    public class OurTeamManager : IOurTeamService
    {
        private readonly IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void TInsert(OurTeam t)
        {
            _ourTeamDal.Insert(t);
        }

        public void TUpdate(OurTeam t)
        {
            _ourTeamDal.Update(t);
        }
        public void TDelete(OurTeam t)
        {
            _ourTeamDal.Delete(t);
        }

        public OurTeam TGetByID(int id)
        {
            return _ourTeamDal.GetByID(id);
        }

        public List<OurTeam> TGetList()
        {
            return _ourTeamDal.GetList();
        }


    }
}
