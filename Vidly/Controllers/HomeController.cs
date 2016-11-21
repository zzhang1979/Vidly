using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        //to allow home page to public user without authentication
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";


            return View();
        }
    }
}