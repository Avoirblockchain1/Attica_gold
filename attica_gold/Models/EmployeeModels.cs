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

    [Table("tblEmployee")]
    public class EmployeeModels
    {
        [Key]
        public int id { get; set; }
        public int employee_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string mobile_number { get; set; }
        public string alter_mobile_number { get; set; }
        public string mail_id { get; set; }
        public string permanet_address { get; set; }
        public string address2 { get; set; }
        public string employee_role { get; set; }
        public string createdat { get; set; }
        public string modifiedat { get; set; }
        public string deletedat { get; set; }

    }
    public class EmployeeContext : DbContext
    {
        public DbSet<EmployeeModels> employee { get; set; }
    }

    /*public class AtticagoldDB : DbContext
    {
        public AtticagoldDB() : base("name=AtticagoldDB")
        {
        }
        public DbSet<EmployeeModels> employees { get; set; }
        
    }*/

}