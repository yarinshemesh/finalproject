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
    
    public partial class Movie_Deal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie_Deal()
        {
            this.Movie_Deal_Details = new HashSet<Movie_Deal_Details>();
        }
    
        public int Id { get; set; }
        public int Worker { get; set; }
        public int Costumer { get; set; }
        public int Movie { get; set; }
        public System.DateTime OrderDate { get; set; }
    
        public virtual Costumers Costumers { get; set; }
        public virtual Movies Movies { get; set; }
        public virtual Workers Workers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie_Deal_Details> Movie_Deal_Details { get; set; }
    }
}
