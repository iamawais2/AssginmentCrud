﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssginmentCrud.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
    }
}