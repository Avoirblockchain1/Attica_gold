using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attica_gold.Controllers
{
    public class BranchManagerController : Controller
    {
        // GET: BranchManager
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Appointment()
        {
            return View();
        }
        public ActionResult NewAppointment()
        {
            return View();
        }

    }
}