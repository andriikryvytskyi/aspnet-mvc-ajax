using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ASPNETAjaxMVCSandbox.App_Start.Routing
{
    public class ExcludeController : IRouteConstraint
    {
        private readonly string _controller;

        public ExcludeController(string controller)
        {
            _controller = controller;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            throw new NotImplementedException();
        }
    }
}