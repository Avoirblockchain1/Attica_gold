using attica_gold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data.Sql;
using attica_gold.DatabaseContext;

namespace attica_gold.Controllers
{
    public class CustomerDealController : Controller
    {
        
        // GET: CustomerDeal
        public ActionResult Login()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            return View();
        }
        //OTPValidation
        public ActionResult OTPValidation()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            return View();
        }
        //DocumentSubmit
        public ActionResult DocumentSubmit()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            return View();
        }
        public ActionResult SubmitForm()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            return View();
        }
        public ActionResult Receipt()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            return View();
        }
        public ActionResult FeedbackForm()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            return View();
        }
    }
}