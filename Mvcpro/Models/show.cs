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
    
    public partial class show
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public show()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int show_id { get; set; }
        public int movie_id { get; set; }
        public int cinema_id { get; set; }
        public System.DateTime start_time { get; set; }
        public System.DateTime end_time { get; set; }
        public Nullable<System.DateTime> show_date { get; set; }
    
        public virtual cinema cinema { get; set; }
        public virtual movy movy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}