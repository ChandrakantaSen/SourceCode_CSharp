using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab7._2_CodeFirstUsingStoredProcedure.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}