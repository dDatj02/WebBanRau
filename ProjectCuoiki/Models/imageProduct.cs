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
    
    public partial class imageProduct
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string meta { get; set; }
        public Nullable<bool> hide { get; set; }
        public Nullable<System.DateTime> datebegin { get; set; }
        public Nullable<int> order { get; set; }
        public byte[] img { get; set; }
        public Nullable<int> idproduct { get; set; }
    
        public virtual product product { get; set; }
    }
}
