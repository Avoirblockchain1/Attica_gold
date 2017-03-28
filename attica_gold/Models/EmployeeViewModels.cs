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

    [Table("employees")]
    public class EmployeeViewModels
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string AltPhoneNumber { get; set; }
        public string Street { get; set; }
        public string City  { get; set; }
        public string Pincode { get; set; }
        public string email  { get; set; }


        // public string first_name { get; set; }
        // public string middle_name { get; set; }
        // public string last_name { get; set; }
        // public string city { get; set; }
        // public string state { get; set; }
        // public string pin { get; set; }
        // public string email { get; set; }
        // public string phone { get; set; }
        // public string  altphone { get; set; }
        // public string role { get; set; }


    }
    public class AtticagoldDB : DbContext
    {
        public AtticagoldDB() : base("name=AtticagoldDB")
        {
        }
        public DbSet<EmployeeViewModels> employees { get; set; }



    }

}