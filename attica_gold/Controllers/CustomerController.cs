using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attica_gold.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()

        {
           // return Redirect("/profile/cse/Customer/Index");
      //     Response.Redirect("/profile/cse/Customer/Index");
            return View();
        }
    }
}