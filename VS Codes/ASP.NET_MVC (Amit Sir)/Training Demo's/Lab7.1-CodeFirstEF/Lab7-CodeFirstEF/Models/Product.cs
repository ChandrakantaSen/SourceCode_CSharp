using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7_CodeFirstEF.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
    }
}