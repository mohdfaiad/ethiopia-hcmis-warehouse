using System;
using System.Collections.Generic;

namespace HCMIS.Concrete.Models
{
    public class vwGetItemBalance
    {
        public string ItemName { get; set; }
        public string ATC { get; set; }
        public string Strength { get; set; }
        public Nullable<int> ABCID { get; set; }
        public string ABC { get; set; }
        public string VEN { get; set; }
        public Nullable<int> VENID { get; set; }
        public Nullable<bool> IsFree { get; set; }
        public Nullable<bool> IsDiscontinued { get; set; }
        public Nullable<bool> EDL { get; set; }
        public Nullable<bool> Refrigeratored { get; set; }
        public Nullable<bool> Pediatric { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<System.DateTime> LastDate { get; set; }
        public Nullable<long> SOH { get; set; }
        public Nullable<long> PhysicalCount { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> DosageFormID { get; set; }
        public string DosageForm { get; set; }
        public int UnitID { get; set; }
        public string Unit { get; set; }
        public string StockCode { get; set; }
        public Nullable<int> IINID { get; set; }
        public int ID { get; set; }
        public Nullable<bool> IsInHospitalList { get; set; }
        public Nullable<long> AMC { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public string StockCodeDACA { get; set; }
        public string Code { get; set; }
        public Nullable<bool> NeedExpiryBatch { get; set; }
    }
}
