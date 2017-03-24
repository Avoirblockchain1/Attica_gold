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
            //   return Redirect(userName+"/Index");
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