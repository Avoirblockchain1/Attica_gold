using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attica_gold.Controllers
    {
  //  [RoutePrefix("BranchMn")]
    public class BranchManagerController : Controller
    {
        // GET: BranchManager.
      //  [Route("branchmgr/BranchManager/Index")]

        public ActionResult Index()
        {
            ViewBag.layout = "~/Views/Shared/_BranchManagerLayout.cshtml";

            //   return Redirect(userName+"/Index");
            return View();
        }
        public ActionResult Appointment()
        {
            ViewBag.layout = "~/Views/Shared/_BranchManagerLayout.cshtml";
            return View();
        }
        public ActionResult NewAppointment()
        {
            ViewBag.layout = "~/Views/Shared/_BranchManagerLayout.cshtml";
            return View();
        }

    }
}