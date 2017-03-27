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
            //string rolee = RouteData.Values["role"].ToString();
           // Console.WriteLine(rolee);
          //  string data = TempData[rolee].ToString();
          //  TempData.Keep(rolee); // above like is mandatory

           // return RedirectToAction("Validate", rolee);
            return View();
        }
        
    public ActionResult Validate()
        {
            //  string data = TempData.Peek(rolee).ToString();
                      String userName = Request["user_name"];
            String password = Request["password"];

            


            if (String.Equals(userName, "admin") && String.Equals(password, "admin"))
            {
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
 
        }
    }
}