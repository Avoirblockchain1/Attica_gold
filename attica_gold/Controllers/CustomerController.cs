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
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }



    }
}