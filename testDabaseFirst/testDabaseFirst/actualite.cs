//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testDabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class actualite
    {
        public int id { get; set; }
        public string titre { get; set; }
        public string description { get; set; }
        public string urlImage { get; set; }
        public System.DateTime dateDebut { get; set; }
        public Nullable<System.DateTime> dateFin { get; set; }
    }
}