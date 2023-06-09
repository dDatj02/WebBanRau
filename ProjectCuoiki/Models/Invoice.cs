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
    
    public partial class Invoice
    {
        public Invoice()
        {
            this.InvoiceDetails = new HashSet<InvoiceDetail>();
        }
    
        public string id { get; set; }
        public string NameCustomer { get; set; }
        public string EmailCustomer { get; set; }
        public string PhoneCustomer { get; set; }
        public string AddressCustomer { get; set; }
        public Nullable<System.DateTime> DateOrder { get; set; }
        public Nullable<System.DateTime> DateDelivery { get; set; }
        public Nullable<decimal> Shippingfee { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<bool> delivered { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
