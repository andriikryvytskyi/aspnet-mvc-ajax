using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETAjaxMVCSandbox.Models;

namespace ASPNETAjaxMVCSandbox.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HelloAjax()
        {
            return Content("Hello Ajax!", "text/plain");
        }

        public ActionResult Sum(int a, int b)
        {
            return Content((a+b).ToString(), "text/plain");
        }

        public ActionResult DisplayObject()
        {
            return Json(new Product() { Name = "Nexus 5", Id = "4434", Price = 500 }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DisplayListObject()
        {
            var l = new List<Product>();
            l.Add(new Product() { Name = "Nexus 5", Id = "5342554", Price = 500 });
            l.Add(new Product() { Name = "Nexus 6", Id = "6642345", Price = 600 });
            l.Add(new Product() { Name = "Nexus 7", Id = "4434234", Price = 700 });
            l.Add(new Product() { Name = "Nexus 8", Id = "4432434", Price = 800 });

            return Json(l, JsonRequestBehavior.AllowGet);
        }
    }
}
