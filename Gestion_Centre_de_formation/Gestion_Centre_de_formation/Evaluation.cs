//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Centre_de_formation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evaluation
    {
        public string observation { get; set; }
        public Nullable<double> note { get; set; }
        public Nullable<System.DateTime> dateEv { get; set; }
        public int n_ins { get; set; }
        public int id_Exam { get; set; }
        public int id_mat { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual Matiere Matiere { get; set; }
        public virtual Stagaire Stagaire { get; set; }
    }
}
