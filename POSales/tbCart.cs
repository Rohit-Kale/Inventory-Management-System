//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSales
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCart
    {
        public int id { get; set; }
        public string transno { get; set; }
        public string pcode { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<decimal> disc_percent { get; set; }
        public Nullable<decimal> disc { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<System.DateTime> sdate { get; set; }
        public string status { get; set; }
        public string cashier { get; set; }
    
        public virtual tbProduct tbProduct { get; set; }
    }
}
