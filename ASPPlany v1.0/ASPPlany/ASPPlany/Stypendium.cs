//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPPlany
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stypendium
    {
        public Stypendium()
        {
            this.Studenci = new HashSet<Studenci>();
        }
    
        public int id_stypendium { get; set; }
        public string rodziaj { get; set; }
        public Nullable<decimal> kwota { get; set; }
    
        public virtual ICollection<Studenci> Studenci { get; set; }
    }
}
