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
    
    public partial class FactionDBLawDB
    {
        public int FactionDBLawDBID { get; set; }
        public int flLawDBID { get; set; }
        public int flFactionDBID { get; set; }
    
        public virtual FactionDB FactionDB { get; set; }
        public virtual LawDB LawDB { get; set; }
    }
}
