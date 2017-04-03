using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace attica_gold.Models
{
    [Table("tblEmployeeDocuments")]
    public class EmployeeDocumentModels
    {
        [Key]
        public int id { get; set; }
        public int employee_id { get; set; }
        public string photo { get; set; }
        public string adhar_card { get; set; }
        public string pan_card { get; set; }
        public string createdat { get; set; }
        public string modifiedat { get; set; }
        public string deletedat { get; set; }
    }
    public class EmployeeDocumentContext : DbContext
    {
        public DbSet<EmployeeDocumentModels> EmployeeDocument { get; set; }
    }

}