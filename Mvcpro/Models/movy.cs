//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvcpro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class movy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public movy()
        {
            this.shows = new HashSet<show>();
        }
    
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public string runtime { get; set; }
        public string poster_path { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<show> shows { get; set; }
    }
}