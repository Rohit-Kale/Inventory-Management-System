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
    
    public partial class tbStockIn
    {
        public int id { get; set; }
        public string refno { get; set; }
        public string pcode { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<System.DateTime> sdate { get; set; }
        public string stockinby { get; set; }
        public string status { get; set; }
        public Nullable<int> supplierid { get; set; }
    
        public virtual tbProduct tbProduct { get; set; }
        public virtual tbSupplier tbSupplier { get; set; }
    }
}
