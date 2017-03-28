using attica_gold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;


namespace attica_gold.Controllers
{
    public class EmployeeController : Controller
    {

        AtticagoldDB db = new AtticagoldDB();
        // GET: Employee
        public ActionResult index()
        {
            var employee = db.employees.SqlQuery("SELECT  * FROM employees").ToList();
            return View(employee);
           
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult store()
        {

            string first_name = Request["first_name"];
            string middle_name = Request["middle_name"];
            string last_name = Request["last_name"];
            string city = Request["city"];
            string  state = Request["state"];
            string  pin = Request["pin"];
            string  email = Request["email"];
            string  gender = Request["gender"];
            string  phone = Request["phone"];
            string  altphone = Request["alternate_phone"];
            string  role = Request["role"];
            string street = "shiviganar";
            string pincode = "234324";

            string sql = "INSERT INTO employees(Name,PhoneNumber,Street,City,Pincode,email) VALUES(@name, @phone_number,@street, @city,@pincode, @email)";
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@name", first_name));
            parameterList.Add(new SqlParameter("@phone_number", phone));
            parameterList.Add(new SqlParameter("@street", street));
            parameterList.Add(new SqlParameter("@city", city));
            parameterList.Add(new SqlParameter("@pincode", pincode));
            parameterList.Add(new SqlParameter("@email", email));
            SqlParameter[] parameters = parameterList.ToArray();
            int result = db.Database.ExecuteSqlCommand(sql, parameters);
            return Content("successfully executed");
        }

        public ActionResult show(int? id )
        {
            var employee = db.employees.SqlQuery("SELECT  * FROM employees where id=15").ToList();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(employee);
            return Content(json);

            //return View();
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