using System;
using System.Collections.Generic;

namespace SYSTEMAPGEntity
{
    public partial class RoleMenu
    {
        public int RoleMenuId { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual Menu? Menu { get; set; }
        public virtual Role? Role { get; set; }
    }
}
