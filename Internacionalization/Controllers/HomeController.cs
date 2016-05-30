using System.Web.Mvc;

namespace Internacionalization.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us";
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SetLanguage(string language)
        {
            RouteData.Values["culture"] = language;

            return RedirectToAction("Index");
        }
    }
}