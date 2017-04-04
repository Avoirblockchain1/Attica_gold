using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace attica_gold.Models
{
    [Table("tblBranches")]
    public class BranchModels
    {
        [Key]
        public int id { get; set; }
        public string branch_id { get; set; }
        public string banch_name { get; set; }
        public string branch_manager_id { get; set; }
        public string mobile_number { get; set; }
        public string alter_mobile_number { get; set; }
        public string street { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string pincode { get; set; }
        public string createdat { get; set; }
        public string modifiedat { get; set; }
        public string deletedat { get; set; }

    }
    public class BranchContext : DbContext
    {
        public DbSet<BranchModels> branch { get; set; }
    }
}