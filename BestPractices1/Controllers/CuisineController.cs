using BestPractices1.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestPractices1.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        //[Authorize(Roles = "Admin")]
        public ActionResult Search(string name = "french")
        {
            //   return View();
            //return Content("Hello!");

            throw new Exception("Something terrible has happened.");

            var message = Server.HtmlEncode(name);
            return Content(message);

            //return RedirectPermanent("http://microsoft.com");

            //return RedirectToAction("Index", "Home", new { name = name });

            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "JuanPo" }, JsonRequestBehavior.AllowGet);
        }


    }
}