//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplomska.Properties.DataSources
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kontrolne_Naloge
    {
        public int ID_Naloge { get; set; }
        public string Naslov_Naloge { get; set; }
        public int Letnik_FK { get; set; }
        public int Predmet_FK { get; set; }
        public int Vrednost_Točk { get; set; }
        public int Kriterij_FK { get; set; }
        public int Stopnja_Težavnosti_FK { get; set; }
        public Nullable<int> Rešitev_FK { get; set; }
    
        public virtual Kriterij Kriterij { get; set; }
        public virtual Letnik Letnik { get; set; }
        public virtual Predmeti Predmeti { get; set; }
        public virtual Rešitve Rešitve { get; set; }
        public virtual Stopnja_Težavnosti Stopnja_Težavnosti { get; set; }
    }
}
