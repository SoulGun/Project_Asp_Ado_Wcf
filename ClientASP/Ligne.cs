//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ligne
    {
        public Ligne()
        {
            this.Noms = new HashSet<Nom>();
        }
    
        public int idligne { get; set; }
        public int idText { get; set; }
        public string lignes { get; set; }
    
        public virtual ICollection<Nom> Noms { get; set; }
    }
}
