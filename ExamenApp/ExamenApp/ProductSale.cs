//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSale
    {
        public int ID { get; set; }
        public System.DateTime SaleDate { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> ClientServiceID { get; set; }
    
        public virtual ClientService ClientService { get; set; }
        public virtual Product Product { get; set; }
    }
}
