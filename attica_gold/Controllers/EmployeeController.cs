﻿using attica_gold.Models;
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
    public class EmployeeController : Controller
    {
        EmployeeTableDataContext db = new EmployeeTableDataContext();

        public ActionResult index()
        {
            //return Content("index page");
            var query = from empdata in db.tblEmployees
                        select empdata;
            var employees = query.ToList();

           //string json = Newtonsoft.Json.JsonConvert.SerializeObject(employees);
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
        public ActionResult store()
        {
            DateTime thisDay = DateTime.Today;
            var date = thisDay.ToString("g");

            tblEmployee emps = new tblEmployee();
            emps.first_name = Request["first_name"];
            emps.last_name = Request["last_name"];
            emps.gender = Request["gender"];
            emps.mobile_number = Request["phone"];
            emps.alter_mobile_number = Request["alternate_phone"];
            emps.email = Request["email"];
            emps.street = Request["street"];
            emps.city = Request["city"];
            emps.state = Request["state"];
            emps.pin = Request["pin"];
            emps.permanet_address = "perment address";
            emps.employee_role = Request["role"];
            emps.createdat = null;
            emps.modifiedat = null;
            emps.deletedat = null;

            db.tblEmployees.InsertOnSubmit(emps);
            db.SubmitChanges();

            return Content("sucessfull");
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