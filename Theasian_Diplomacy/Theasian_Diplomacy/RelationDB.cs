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
    
    public partial class RelationDB
    {
        public RelationDB()
        {
            this.RelationModifierDB = new HashSet<RelationModifierDB>();
        }
    
        public int RelationDBID { get; set; }
        public int rfirstCharacterDBID { get; set; }
        public int rRelationTypeDBID { get; set; }
        public int rsecondCharacterDBID { get; set; }
    
        public virtual CharacterDB CharacterDB { get; set; }
        public virtual CharacterDB CharacterDB1 { get; set; }
        public virtual ICollection<RelationModifierDB> RelationModifierDB { get; set; }
        public virtual RelationTypeDB RelationTypeDB { get; set; }
    }
}