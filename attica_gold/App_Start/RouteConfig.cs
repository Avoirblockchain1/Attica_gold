﻿using System;
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

                    /*   routes.MapRoute(
                name: "ProfileRole",
                url: "profile/{role}/{action}/{id}",
                defaults: new { controller = "role",  action = "Index", id = UrlParameter.Optional }
            );
                        */


            routes.MapRoute(
                name: "cse",
                url: "profile/{controller}/{action}/{id}",
                defaults: new { controller = "Cse", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "admin",
               url: "profile/{controller}/{action}/{id}",
               defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
           );

             routes.MapRoute(
                name: "BranchManager",
                url: "profile/{controller}/{action}/{id}",
                defaults: new { controller = "BranchManager", action = "Index", id = UrlParameter.Optional }
            );

            

            routes.MapRoute(
                name: "csebranch",
                url: "profile/Cse/{controller}/{action}/{id}",
                defaults: new { controller = "Branch", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "csecustomer",
                url: "profile/cse/{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional }
            );

                      
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
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
 