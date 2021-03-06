using System;
using System.Collections.Generic;

namespace HCMIS.Concrete.Models
{
    public class UserPhysicalStore
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> PhysicalStoreID { get; set; }
        public Nullable<bool> CanAccess { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public virtual PhysicalStore PhysicalStore { get; set; }
        public virtual User User { get; set; }
    }
}
