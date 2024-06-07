using System;
using System.Collections.Generic;

namespace SYSTEMAPGEntity
{
    public partial class Sale
    {
        public Sale()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int SaleId { get; set; }
        public string? SaleNumber { get; set; }
        public int? DocumentTypeSaleId { get; set; }
        public int? UserId { get; set; }
        public string? ClientDocument { get; set; }
        public string? ClientName { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? Total { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual DocumentTypeSale? DocumentTypeSale { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
