//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppGestFacturationDeau
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consomation
    {
        public int IdCompteur { get; set; }
        public System.DateTime Date_debut { get; set; }
        public System.DateTime Date_fin { get; set; }
        public int Ancienne { get; set; }
        public int Nouvelle { get; set; }
        public decimal Perenete { get; set; }
    
        public virtual Compteur Compteur { get; set; }
    }
}
