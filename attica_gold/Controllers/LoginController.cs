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
            return View();
        }
        
        public ActionResult Validate()
        {
           
            
            String userName = Request["user_name"];
            String password = Request["password"];

            //var data = new { username = userName, password = password };
            //return Json(data, JsonRequestBehavior.AllowGet);

            LoginDataContext loginObject = new LoginDataContext();
            EmployeeDataContext employeeObject = new EmployeeDataContext();

            var login = (from logintable in loginObject.tblLogins
                         join employee in employeeObject.tblEmployees
                         on logintable.employee_id equals employee.employee_id
                         where logintable.username == userName && logintable.user_password == password
                         select new {
                             logintable.employee_id,
                             employee.employee_role,
                         }).First();



            string json = Newtonsoft.Json.JsonConvert.SerializeObject(login);
            return Content(json);
            /*
            if (String.Equals(userName, "admin") && String.Equals(password, "admin")) {
                Response.Redirect("/profile/Admin/Index");
            }
            else if (String.Equals(userName, "cse") && String.Equals(password, "cse"))
            {
                Response.Redirect("/profile/Cse/Index");
            }
            else if (String.Equals(userName, "branchmanager") && String.Equals(password, "branchmanager"))
            {
                Response.Redirect("/profile/BranchManager/Index");
            }
            else
            {
                Response.Redirect("index");
            }
            return Content("Exception Occues");
            */
        }
    }
}