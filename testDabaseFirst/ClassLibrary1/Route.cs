//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Route()
        {
            this.Path = new HashSet<Path>();
        }
    
        public int Id { get; set; }
        public int Seats { get; set; }
        public int StartStopId { get; set; }
        public int EndStopId { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public Nullable<double> Distance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Path> Path { get; set; }
        public virtual Stop Stop { get; set; }
        public virtual Stop Stop1 { get; set; }
    }
}
