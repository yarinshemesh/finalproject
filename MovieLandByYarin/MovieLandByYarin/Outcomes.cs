//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieLandByYarin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outcomes
    {
        public int Id { get; set; }
        public int Worker { get; set; }
        public string Price { get; set; }
        public int Supplier { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }
        public string Notes { get; set; }
    
        public virtual Suppliers Suppliers { get; set; }
        public virtual Workers Workers { get; set; }
    }
}