﻿using System;
using System.Collections.Generic;

namespace SYSTEMAPGEntity
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
