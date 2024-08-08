using BusinessLayer.Concerete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TRAVERSAL.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public  IViewComponentResult Invoke ()

        {
            var values = testimonialManager.GetList();
            return View(values);
        }
    }
}
