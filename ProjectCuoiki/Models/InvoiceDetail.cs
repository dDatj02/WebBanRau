//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCuoiki.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceDetail
    {
        public string idInvoice { get; set; }
        public int idProduct { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> total { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual product product { get; set; }
    }
}
