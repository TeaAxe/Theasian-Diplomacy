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
    
    public partial class RelationLevelDB
    {
        public int RelationLevelDBID { get; set; }
        public Nullable<int> level { get; set; }
        public string textDialogue { get; set; }
        public string textLetter { get; set; }
        public int rlDialogueDBID { get; set; }
    
        public virtual DialogueDB DialogueDB { get; set; }
    }
}