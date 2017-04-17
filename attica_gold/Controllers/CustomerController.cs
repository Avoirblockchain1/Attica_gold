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
    public class CustomerController : Controller
    {

        CustomerDataContext customerObject = new CustomerDataContext();
        // GET: Customer
        public ActionResult Index()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";

            var query = from customerdata in customerObject.tblCustomers
                       select customerdata;
            var customers = query.ToList();

          // string json = Newtonsoft.Json.JsonConvert.SerializeObject(customers);
          // return Content("samle");

            ViewBag.customerdata = customers;

            return View();
            
        }
        public ActionResult show(int id)
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";

            var query = (from customerdata in customerObject.tblCustomers
                         where customerdata.id == id
                         select customerdata);
            var customer = query.FirstOrDefault();
            ViewBag.customerdata = customer;

           // string json = Newtonsoft.Json.JsonConvert.SerializeObject(customer);
           // return Content(json);
           
            return View();
        }


        public ActionResult Create()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";

            return View();
        }

        public ActionResult delete(int id)
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";

            var query = (from customerdata in customerObject.tblCustomers
                        where customerdata.id == id
                         select customerdata).Single();
            customerObject.tblCustomers.DeleteOnSubmit(query);
            customerObject.SubmitChanges();
            var redirectUrl = "/profile/" + role + "/customer/index";
            Response.Redirect(redirectUrl);
            return View();
        }

        public ActionResult edit(int id)
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";

            var query = (from customerdata in customerObject.tblCustomers
                         where customerdata.id == id
                        select customerdata);
            var customer = query.FirstOrDefault();
            ViewBag.customerdata = customer;
            return View();
        }

        [HttpPost]
        public ActionResult store()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";

            tblCustomer tblObj = new tblCustomer();
            tblObj.customer_id = Request["customer_id"];
            tblObj.first_name = Request["first_name"];
            tblObj.last_name = Request["last_name"];
            tblObj.gender = Request["gender"];
            tblObj.mobile_number = Request["phone"];
            tblObj.alter_mobile_number = Request["alternate_phone"];
            tblObj.email = Request["email"];
            tblObj.street = Request["street"];
            tblObj.city = Request["city"];
            tblObj.state = Request["state"];
            tblObj.pin = Request["pin"];
            tblObj.permanet_address = "perment address";
            tblObj.createdat = null;
            tblObj.modifiedat = null;
            tblObj.deletedat = null;
            
            
            customerObject.tblCustomers.InsertOnSubmit(tblObj);
            customerObject.SubmitChanges();

            var redirectUrl = "/profile/" + role + "/customer/index";
            Response.Redirect(redirectUrl);
            return View();
        }

        public ActionResult update()
        {
            var role = RouteData.Values["role"].ToString();
            ViewBag.role = role;
            ViewBag.layout = "~/Views/Shared/_" + role + "Layout.cshtml";

            int id = Convert.ToInt32(Request["id"]);
         
           var query = (from customerdata in customerObject.tblCustomers
                        where customerdata.id == id
                        select customerdata);
           var customer = query.FirstOrDefault();
            
            customer.customer_id = Request["customer_id"];
            customer.first_name = Request["first_name"];
            customer.last_name = Request["last_name"];
            customer.gender = Request["gender"];
            customer.mobile_number = Request["phone"];
            customer.alter_mobile_number = Request["alternate_phone"];
            customer.email = Request["email"];
            customer.street = Request["street"];
            customer.city = Request["city"];
            customer.state = Request["state"];
            customer.pin = Request["pin"];
            customer.permanet_address = "perment address";
            customer.createdat = null;
            customer.modifiedat = null;
            customer.deletedat = null;
            
            customerObject.SubmitChanges();
            var redirectUrl = "/profile/" + role + "/customer/index";
            Response.Redirect(redirectUrl);
            return View();
        }
       


    }
}