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
    
    public partial class reponse
    {
        public int id { get; set; }
        public string contenu { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> id_question { get; set; }
        public Nullable<int> id_utilisateur { get; set; }
    
        public virtual question question { get; set; }
        public virtual utilisateur utilisateur { get; set; }
    }
}