using System;
using System.Collections.Generic;
using BusinessLayer.Abstact;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public About GetById(int id)
        {
            return _aboutDal.TGetById(id);
        }

        public void Add(About entity)
        {
            _aboutDal.TInsert(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.TDelete(entity);
        }

        public List<About> GetList()
        {
            return _aboutDal.TGetList();
        }

        public void Update(About entity)
        {
            _aboutDal.TUpdate(entity);
        }
    }
}
