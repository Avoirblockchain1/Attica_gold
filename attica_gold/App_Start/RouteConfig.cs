using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace attica_gold
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            

            routes.MapRoute(
                name: "Admin",
                url: "profile/{controller}/{action}/{id}",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "cse",
                url: "profile/{controller}/{action}/{id}",
                defaults: new { controller = "Cse", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "BranchManager",
                url: "profile/{controller}/{name}/{action}/{id}",
                defaults: new { controller = "BranchManager",name=UrlParameter.Optional, action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }

      /*  public class UserNameConstraint : IRouteConstraint
        {
            public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
            {
                List<string> users = new List<string> { "admin", "branchmn", "cse" };
                throw new NotImplementedException();
            }
        }
        */
    }
}
 