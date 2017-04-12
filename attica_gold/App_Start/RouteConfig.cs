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
                   name: "appointmnt",
                   url: "profile/BranchManager/Appointment",
                     defaults: new { controller = "BranchManager", action = "Appointment" }
               );
            routes.MapRoute(
                name: "newappointmnt",
                url: "profile/BranchManager/NewAppointment",
                  defaults: new { controller = "BranchManager", action = "NewAppointment" }
            );
            routes.MapRoute(
                name: "empindex",
                url: "profile/{role}/Employee",
                  defaults: new { controller = "Employee", action = "Index" }
            );

            routes.MapRoute(
                name: "empaction",
                url: "profile/{role}/Employee/{action}",
                  defaults: new { controller = "Employee" }
            );

          

            routes.MapRoute(

               name: "profilerole",
               url: "profile/{controller}",
               defaults: new { action = "Index" }
           );

            routes.MapRoute(
                 name: "roleitem",
                 url: "profile/{role}/{controller}",
                   defaults: new { action = "Index" }
             );

            routes.MapRoute(
                 name: "roleitemlogin",
                 url: "profile/{role}/{controller}/{action}",
                   defaults: new { controller = "CustomerDeal", action = "Login" }
             );


            routes.MapRoute(
                name: "Defaultlogin",
               url: "Login",
               defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
           );


            routes.MapRoute(

               name: "DefaultV",
               url: "Login/validate",

               defaults: new { controller = "Login", action = "validate", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



           
        }
    }
} 