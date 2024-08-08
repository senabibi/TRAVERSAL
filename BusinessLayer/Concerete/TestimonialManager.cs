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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public Testimonial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.TGetList();
        }

        public void Update(Testimonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
