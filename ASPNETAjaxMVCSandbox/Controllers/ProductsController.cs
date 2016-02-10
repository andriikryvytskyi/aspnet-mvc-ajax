using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETAjaxMVCSandbox.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult All()
        {
            return Content("List of products.");
        }

        public ActionResult GetProduct(int Id)
        {
            return Content(string.Format("Product with ID: {0}", Id));
        }

    }
}
