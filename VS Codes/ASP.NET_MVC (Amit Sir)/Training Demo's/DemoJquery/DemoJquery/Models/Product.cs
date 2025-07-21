using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoJquery.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [DisplayName("Product Name")]
        [StringLength(50, ErrorMessage="Product Name is too long")]
        public string Name { get; set; }

        [DisplayName("Product Quantity")]
        public int Qty { get; set; }

        public decimal Price { get; set; }
        public DateTime EntryDate { get; set; }
    }
}