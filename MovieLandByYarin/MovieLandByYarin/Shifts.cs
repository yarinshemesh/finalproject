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
    
    public partial class Shifts
    {
        public int Id { get; set; }
        public int Worker { get; set; }
        public string Date { get; set; }
        public string Start_time { get; set; }
        public string End_time { get; set; }
    
        public virtual Workers Workers { get; set; }
    }
}