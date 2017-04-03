using attica_gold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data.Sql;


namespace attica_gold.Controllers
{
    public class EmployeeController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public ActionResult index()
        {
            //return Content("index page");
            var query = from empdata in db.tblEmployee
                        select empdata;
            var employees = query.ToList();

           // string json = Newtonsoft.Json.JsonConvert.SerializeObject(employees);
            //return Content(json);
           
            ViewBag.employeedata = employees;
            return View();



        }
        [HttpGet]
        public ActionResult create()
        {
            return View();



        }

        [HttpPost]
        

        
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