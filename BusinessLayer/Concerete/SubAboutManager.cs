using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstact;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concerete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Add(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public SubAbout GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetList()
        {
            return _subAboutDal.TGetList();
        }

        public void Update(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
