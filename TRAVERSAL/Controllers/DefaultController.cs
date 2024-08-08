using Microsoft.AspNetCore.Mvc;

namespace TRAVERSAL.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
