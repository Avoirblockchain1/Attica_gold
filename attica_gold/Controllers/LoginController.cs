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
    public class LoginController : Controller
    {
      
        // GET: Login
        public ActionResult Index()
        {
            //string rolee = RouteData.Values["role"].ToString();
           // Console.WriteLine(rolee);
          //  string data = TempData[rolee].ToString();
          //  TempData.Keep(rolee); // above like is mandatory

           // return RedirectToAction("Validate", rolee);
            return View();
        }
        
    public ActionResult Validate()
        {

            
            String userName = Request["user_name"];
            String password = Request["password"];

           
            EmployeeDataContext loginObject = new EmployeeDataContext();
           
            var login = (from logintable in loginObject.tblLogins
                         join employee in loginObject.tblEmployees
                         on logintable.employee_id equals employee.employee_id
                         where logintable.username == userName && logintable.user_password == password
                         select employee ).FirstOrDefault(); 

           
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(login.first_name);
            return Content(json);
            
            /*
            if (String.Equals(userName, "admin") && String.Equals(password, "admin"))
            {
                Response.Redirect("/profile/Admin");

            }
            else if (String.Equals(userName, "cse") && String.Equals(password, "cse"))
            {
                Response.Redirect("/profile/Cse");
            }
            else if (String.Equals(userName, "branchmanager") && String.Equals(password, "branchmanager"))
            {
                Response.Redirect("/profile/BranchManager");
            }
            else
            {
                Response.Redirect("/Login");
            }
            return Content("Exception Occues");
            */
        }
    }
}