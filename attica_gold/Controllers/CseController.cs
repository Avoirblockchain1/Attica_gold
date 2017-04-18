using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attica_gold.Controllers
{
    public class CseController : Controller
    {
        // GET: Cse
        public ActionResult Index()
        {
            ViewBag.layout = "~/Views/Shared/_CseLayout.cshtml";
            return View();
        }
    }
}