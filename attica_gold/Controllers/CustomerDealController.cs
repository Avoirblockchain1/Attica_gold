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
            return View();
        }
        //OTPValidation
        public ActionResult OTPValidation()
        {
            return View();
        }
        //DocumentSubmit
        public ActionResult DocumentSubmit()
        {
            return View();
        }
        public ActionResult SubmitForm()
        {
            return View();
        }
        public ActionResult Receipt()
        {
            return View();
        }
        public ActionResult FeedbackForm()
        {
            return View();
        }
    }
}