﻿using System;
using System.Collections.Generic;

namespace SYSTEMAPGEntity
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? Barcode { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public int? Stock { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageName { get; set; }
        public decimal? Price { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual Category? Category { get; set; }
    }
}
