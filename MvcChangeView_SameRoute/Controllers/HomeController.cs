using System.Web.Mvc;

namespace MvcChangeView_SameRoute.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Country(int id)
        {
            if (id == 1)
                return View("Brasil");

            if (id == 2)
                return View("Chile");

            if (id == 3)
                return View("Paraguai");

            if (id == 4)
                return View("Uruguai");

            return View();
        }

    }
}