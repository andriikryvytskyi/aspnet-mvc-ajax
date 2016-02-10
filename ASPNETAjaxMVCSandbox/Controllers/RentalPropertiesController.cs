using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETAjaxMVCSandbox.Controllers
{
    public class RentalPropertiesController : Controller
    {
        public ActionResult All()
        {
            return Content("All Rental Properties.");
        }

        public ActionResult RentalProperty(string rentalPropertyName)
        {
            return Content(string.Format("Rental property with name: {0}", rentalPropertyName));
        }

        public ActionResult Unit(string rentalPropertyName, string unitNo)
        {
            return Content(string.Format("Rental property: {0}, Unit: {1}", rentalPropertyName, unitNo));
        }
    }
}
