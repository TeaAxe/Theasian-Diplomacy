//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Theasian_Diplomacy
{
    using System;
    using System.Collections.Generic;
    
    public partial class LawDB
    {
        public LawDB()
        {
            this.FactionDBLawDB = new HashSet<FactionDBLawDB>();
        }
    
        public int LawDBID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<int> entryEffectMethodID { get; set; }
        public Nullable<int> removeEffectMethodID { get; set; }
    
        public virtual ICollection<FactionDBLawDB> FactionDBLawDB { get; set; }
    }
}