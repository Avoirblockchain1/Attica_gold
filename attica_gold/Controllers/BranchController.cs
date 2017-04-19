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
    public class BranchController : Controller
    {
        BranchDataContext branchObject = new BranchDataContext();
        // GET: Branch
        public ActionResult Index()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            var query = from branchdata in branchObject.tblBranches
                        select branchdata;
            var branches = query.ToList();

            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(branches);
            //return Content(json);

            ViewBag.branchdata = branches;
          
            return View();
        }
        public ActionResult create()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
         
            return View();
        }
        [HttpPost]
        public ActionResult show()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role+ "Layout.cshtml";
            //return Content("index page");
            var query = from branchdata in branchObject.tblBranches
                        select branchdata;
            var branches = query.ToList();

           //string json = Newtonsoft.Json.JsonConvert.SerializeObject(branches);
           //return Content(json);
           
            ViewBag.branchdata = branches;
            return View();
        }

        public ActionResult show(int id)
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            var query = (from branchdata in branchObject.tblBranches
                         where branchdata.id == id
                         select branchdata);
            var branches = query.FirstOrDefault();
            ViewBag.branchdata = branches;

            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(branches);
            //return Content(json);

            return View();
        }


        [HttpPost]
        public ActionResult store()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            
            tblBranch branchObj = new tblBranch();
            branchObj.branch_id = Request["branch_id"];
            branchObj.branch_name = Request["branch_name"];
            branchObj.branch_manager_id = Request["branch_manager_id"];
            branchObj.mobile_number = Request["phone"];
            branchObj.alter_mobile_number = Request["alternate_phone"];
            branchObj.street = Request["street"];
            branchObj.city = Request["city"];
            branchObj.state = Request["state"];
            branchObj.pincode = Request["pin"];
            branchObj.createdat = null;
            branchObj.modifiedat = null;
            branchObj.deletedat = null;

            branchObject.tblBranches.InsertOnSubmit(branchObj);
            branchObject.SubmitChanges();
            var redirectUrl = "/profile/" +role +"/branch/index";
            Response.Redirect(redirectUrl);
            return View();
            
        }

       

        public ActionResult delete(int id)
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            var query = (from branchdata in branchObject.tblBranches
                         where branchdata.id == id
                         select branchdata).Single();
            branchObject.tblBranches.DeleteOnSubmit(query);
            branchObject.SubmitChanges();
            var redirectUrl = "/profile/" + role + "/branch/index";
            Response.Redirect(redirectUrl);
            return View();
        }
        public ActionResult edit(int id)
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.ct = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            var query = (from branchdata in branchObject.tblBranches
                         where branchdata.id == id
                         select branchdata);
            var branches = query.FirstOrDefault();
            ViewBag.branchdata = branches;
            return View();
        }
        public ActionResult update()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.ct = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";
            int id = Convert.ToInt32(Request["id"]);
         
            var query = (from branchdata in branchObject.tblBranches
                         where branchdata.id == id
                         select branchdata);
            var branchObj = query.FirstOrDefault();
            
            branchObj.branch_name = Request["branch_name"];
            branchObj.branch_manager_id = Request["branch_manager_id"];
            branchObj.mobile_number = Request["phone"];
            branchObj.alter_mobile_number = Request["alternate_phone"];
            branchObj.street = Request["street"];
            branchObj.city = Request["city"];
            branchObj.state = Request["state"];
            branchObj.pincode = Request["pin"];
            branchObj.createdat = null;
            branchObj.modifiedat = null;
            branchObj.deletedat = null;

            branchObject.SubmitChanges();
            var redirectUrl = "/profile/" + role + "/branch/index";
            Response.Redirect(redirectUrl);
            return View();
        }

    }
  
}