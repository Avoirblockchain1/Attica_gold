using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

            
            if (String.Equals(userName, "admin") && String.Equals(password, "admin")) {
                Response.Redirect("/Admin/Index");
            }
            else if (String.Equals(userName, "cse") && String.Equals(password, "cse"))
            {
                Response.Redirect("/Cse/Index");
            }
            else if (String.Equals(userName, "branchmanager") && String.Equals(password, "branchmanager"))
            {
                Response.Redirect("/BranchManager/Index");
            }
            else
            {
                Response.Redirect("index");
            }
            return Content("Exception Occues");
 
        }
    }
}