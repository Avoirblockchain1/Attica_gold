using attica_gold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
<<<<<<< HEAD
using System.Data.Sql;
using attica_gold.DatabaseContext;
=======
>>>>>>> 62f045474f010d01ca0e61cecab0bafa36a1d959

namespace attica_gold.Controllers
{
    public class BranchController : Controller
    {
        BranchDataContext branchObject = new BranchDataContext();
        // GET: Branch
        AtticagoldDB db = new AtticagoldDB();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult create()
        { 
               return View();
        }
        [HttpPost]
        public ActionResult show()
        {
            //return Content("index page");
            var query = from branchdata in branchObject.tblBranches
                        select branchdata;
            var branches = query.ToList();

           //string json = Newtonsoft.Json.JsonConvert.SerializeObject(branches);
           //return Content(json);
           
            ViewBag.branchdata = branches;
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
        

            

            Response.Redirect("/branch/index");
            return View();
        }

        public ActionResult show(int id)
        {
            var query = (from branchdata in branchObject.tblBranches
                         where branchdata.id == id
                         select branchdata);
            var branches = query.FirstOrDefault();
            ViewBag.branchdata = branches;

           //string json = Newtonsoft.Json.JsonConvert.SerializeObject(branches);
           //return Content(json);

            return View();
        }

        public ActionResult delete(int id)
        {
           var query = (from branchdata in branchObject.tblBranches
                         where branchdata.id == id
                         select branchdata).Single();
            branchObject.tblBranches.DeleteOnSubmit(query);
            branchObject.SubmitChanges();
            Response.Redirect("/branch/index");
            return View();
        }
        public ActionResult edit(int id)
        {
            var query = (from branchdata in branchObject.tblBranches
                         where branchdata.id == id
                         select branchdata);
            var branches = query.FirstOrDefault();
            ViewBag.branchdata = branches;
            return View();
        }
        public ActionResult update()
        {
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
            Response.Redirect("/employee/index");
            return View();
        }

    }
  
}