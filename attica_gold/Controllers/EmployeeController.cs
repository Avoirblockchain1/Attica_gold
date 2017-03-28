using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attica_gold.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult index()
        {
            return View();
        }
        public ActionResult create()
        {
            return View();
        }

        public ActionResult store()
        {

            string first_name = Request['first_name'];
            return Content("first_name");
        }

        public ActionResult show()
        {
            return View();
        }
                public ActionResult delete()
        {
            return View();
        }
        public ActionResult edit()
        {
            return View();
        }
        public ActionResult update()
        {
            return View();
        }

    }
}