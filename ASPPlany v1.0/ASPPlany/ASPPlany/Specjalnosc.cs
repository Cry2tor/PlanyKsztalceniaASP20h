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
    
    public partial class Specjalnosc
    {
        public Specjalnosc()
        {
            this.Przedmioty = new HashSet<Przedmioty>();
            this.Studenci = new HashSet<Studenci>();
        }
    
        public int id_specjalnosc { get; set; }
        public string nazwa { get; set; }
        public Nullable<int> stopien { get; set; }
        public int Katedra_id_katedra { get; set; }
    
        public virtual Katedra Katedra { get; set; }
        public virtual ICollection<Przedmioty> Przedmioty { get; set; }
        public virtual ICollection<Studenci> Studenci { get; set; }
    }
}