using System;
using System.Collections.Generic;

namespace SYSTEMAPGEntity
{
    public partial class CorrelativeNumber
    {
        public int CorrelativeNumberId { get; set; }
        public int? LastNumber { get; set; }
        public int? DigitCount { get; set; }
        public string? Management { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
