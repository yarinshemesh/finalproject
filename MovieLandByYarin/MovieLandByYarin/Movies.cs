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
    
    public partial class Movies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movies()
        {
            this.Movie_Deal = new HashSet<Movie_Deal>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Director { get; set; }
        public string Time { get; set; }
        public string Age_Limit { get; set; }
        public string Incomes { get; set; }
        public string Everge_grade { get; set; }
    
        public virtual Directors Directors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie_Deal> Movie_Deal { get; set; }
    }
}
