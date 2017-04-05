using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using attica_gold.Models;
using attica_gold.Helpers;

namespace attica_gold.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userid , string password)
        {
            LoginViewModels vm = new LoginViewModels();

            LogIndetailsResp resp = vm.GetLoginDetails(userid, password);

            if (!resp.IsUserExists)
            {

            }
            else if (!resp.IsUserIdPasswordmatched)
            {

            }
            else if (!resp.IsUserActive)
            {

            }

            string role = resp.Role;

            if (role == "admin")
            {
                Response.Redirect("/profile/Admin/Index");
            }
            else if (role == "cse")
            {
                Response.Redirect("/profile/Cse/Index");
            }
            else if (branchmanager == role)
            {
                Response.Redirect("/profile/BranchManager/Index");
            }
            else
            {
                Response.Redirect("index");
            }



            return View(user);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Validate()
        {

            String userName = Request["user_name"];
            String password = Request["password"];

            
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
 
        }
    }
}