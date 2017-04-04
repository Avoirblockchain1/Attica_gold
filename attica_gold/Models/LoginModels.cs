using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace attica_gold.Models
{
    [Table("tblLogin")]
    public class LoginModels
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string user_password { get; set; }
        public string employee_id { get; set; }
        public string createdat { get; set; }
        public string modifiedat { get; set; }
        public string deletedat { get; set; }
    }

    public class LoginContext : DbContext
    {
        public DbSet<LoginModels> login { get; set; }
    }
}