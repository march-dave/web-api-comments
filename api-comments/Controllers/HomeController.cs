using System.Web.Http.Cors;
using System.Web.Mvc;

namespace api_comments.Controllers
{
    /// <summary>
    /// HomeController
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HomeController : Controller
    {
        /// <summary>
        /// HomeController Index
        /// </summary>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
