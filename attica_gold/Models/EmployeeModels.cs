using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace attica_gold.Models
{

    [Table("tblEmployees")]
    public class EmployeeModels
    {
        [Key]
        public int id { get; set; }
        public string employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string mobile_number { get; set; }
        public string alter_mobile_number { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string pin { get; set; }
        public string permanet_address { get; set; }
        public string employee_role { get; set; }
        public string createdat { get; set; }
        public string modifiedat { get; set; }
        public string deletedat { get; set; }

    }
    public class EmployeeContext : DbContext
    {
        public DbSet<EmployeeModels> employee { get; set; }
    }

   

}