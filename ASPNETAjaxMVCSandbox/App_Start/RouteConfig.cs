using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPNETAjaxMVCSandbox
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "RentalPropertyUnit",
                url: "RentalProperties/{rentalPropertyName}/Units/{unitNo}",
                defaults: new
                {
                    controller = "RentalProperties",
                    action = "Unit",
                }
            );

            // RentalProperties/Boardwalk
            routes.MapRoute(
                name: "RentalProperty",
                url: "RentalProperties/{rentalPropertyName}",
                defaults: new
                {
                    controller = "RentalProperties",
                    action = "RentalProperty",
                }
            );

            // RentalProperties/
            routes.MapRoute(
                name: "RentalProperties",
                url: "RentalProperties",
                defaults: new
                {
                    controller = "RentalProperties",
                    action = "All",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Products",
                url: "Products/{action}/{id}",
                defaults: new
                {
                    controller = "Products",
                    action = "All",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "Demo",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}