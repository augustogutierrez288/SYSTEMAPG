using System;
using System.Collections.Generic;

namespace SYSTEMAPGEntity
{
    public partial class DocumentTypeSale
    {
        public DocumentTypeSale()
        {
            Sales = new HashSet<Sale>();
        }

        public int DocumentTypeSaleId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
