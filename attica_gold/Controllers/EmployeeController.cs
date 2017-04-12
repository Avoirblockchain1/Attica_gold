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
    public class EmployeeController : Controller
    {
        EmployeeDataContext db = new EmployeeDataContext();

        public ActionResult index()
        {
            //return Content("index page");
            var query = from empdata in db.tblEmployees
                        select empdata;
            var employees = query.ToList();

          // string json = Newtonsoft.Json.JsonConvert.SerializeObject(employees);
          // return Content(json);
           
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
            
            tblEmployee emps = new tblEmployee();
            emps.employee_id = Request["employee_id"];
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
        

            tblEmployeeDocument empsdoc = new tblEmployeeDocument();
            empsdoc.employee_id = Request["employee_id"];
            empsdoc.photo = null;
            empsdoc.adhar_card = null;
            empsdoc.pan_card = null;
            db.tblEmployeeDocuments.InsertOnSubmit(empsdoc);
            db.SubmitChanges();

            
            tblLogin emplogin = new tblLogin();
            emplogin.employee_id = Request["employee_id"];
            emplogin.username = Request["email"];
            emplogin.user_password = Request["email"];
            db.tblLogins.InsertOnSubmit(emplogin);
            db.SubmitChanges();



            Response.Redirect("/employee");
            return View();
        }

        public ActionResult show(int id)
        {
            var query = (from empdata in db.tblEmployees
                         where empdata.id == id
                         select empdata).FirstOrDefault();
            var employeesdata = query;
            ViewBag.employeedata = employeesdata;

           //string json = Newtonsoft.Json.JsonConvert.SerializeObject(employeesdata);
          // return Content(json);

            return View();
        }

        public ActionResult delete(int id)
        {
           var query = (from empdata in db.tblEmployees
                         where empdata.id == id
                         select empdata).Single();

            
            db.tblEmployees.DeleteOnSubmit(query);
            db.SubmitChanges();
            Response.Redirect("/employee");
            return View();
            
        }
        public ActionResult edit(int id)
        {
            var query = (from empdata in db.tblEmployees
                         where empdata.id == id
                         select empdata);
            var employees = query.FirstOrDefault();
            ViewBag.employeedata = employees;
            return View();
        }
        public ActionResult update(int id)
        {
            //int id = Convert.ToInt32(Request["id"]);
         
            var query = (from empdata in db.tblEmployees
                         where empdata.id == id
                         select empdata);
            var employee = query.FirstOrDefault();

           
            employee.employee_id = Request["employee_id"];
            employee.first_name = Request["first_name"];
            employee.last_name = Request["last_name"];
            employee.gender = Request["gender"];
            employee.mobile_number = Request["phone"];
            employee.alter_mobile_number = Request["alternate_phone"];
            employee.email = Request["email"];
            employee.street = Request["street"];
            employee.city = Request["city"];
            employee.state = Request["state"];
            employee.pin = Request["pin"];
            employee.permanet_address = "perment address";
            employee.employee_role = Request["role"];
            employee.createdat = null;
            employee.modifiedat = null;
            employee.deletedat = null;
            UpdateModel(employee);
            db.SubmitChanges();
            //db.SaveChanges();

            Response.Redirect("/employee");
            return View();
           
        }

    }
}