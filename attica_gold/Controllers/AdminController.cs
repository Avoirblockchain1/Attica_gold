﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attica_gold.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

     /*   public ActionResult Index(String uname)
        {
            Response.Redirect("/profile/Admin/uname/Index");

            return Content("Exception Occues");
        }
        */
    }
}