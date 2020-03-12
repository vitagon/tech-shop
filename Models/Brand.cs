﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("Brand")]
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(450)]
        public string Name { get; set; }
    }
}