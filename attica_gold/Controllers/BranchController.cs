using attica_gold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace attica_gold.Controllers
{
    public class BranchController : Controller
    {
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
            return View();
            /*
                        string branch_id = Request["branch_id"];
                        string branchname = Request["branchname"];
                        string branch_manager_id = Request["branch_manager_id"];
                        string phonenumber = Request["phonenumber"];
                        string alter_phone_number = Request["alter_phone_number"];
                        string street = Request["street"];
                        string city = Request["city"];
                        string state = Request["state"];
                        string phone = Request["phone"];
                        string altphone = Request["alternate_phone"];
                        string pincode = Request["pincode"];
                        string address = Request["address"];


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
          */
        }
    }
  
}