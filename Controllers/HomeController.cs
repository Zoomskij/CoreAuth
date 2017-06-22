
using Microsoft.AspNetCore.Mvc;

namespace CoreAuth.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}