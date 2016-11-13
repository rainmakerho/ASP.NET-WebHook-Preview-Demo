using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebHookDemo.Receiver.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult About()
        {
            FormsAuthentication.SetAuthCookie("rainmaker", false);
            ViewBag.Message = "Your application description page.";
            return RedirectToActionPermanent("Index");
        }
    }
}
