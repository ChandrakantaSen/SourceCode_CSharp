﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab8_LINQwithASP.NET.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Quantity")]
        public int Qty { get; set; }
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
    }
}