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
    
    public partial class DialogueDB
    {
        public DialogueDB()
        {
            this.DialogueDBLetterDB = new HashSet<DialogueDBLetterDB>();
            this.RelationLevelDB = new HashSet<RelationLevelDB>();
        }
    
        public string code { get; set; }
        public int DialogueDBID { get; set; }
    
        public virtual ICollection<DialogueDBLetterDB> DialogueDBLetterDB { get; set; }
        public virtual ICollection<RelationLevelDB> RelationLevelDB { get; set; }
    }
}
