//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoVoyageV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voyage
    {
        public int IdVoyage { get; set; }
        public System.DateTime DateAller { get; set; }
        public System.DateTime DateRetour { get; set; }
        public int PlacesDisponibles { get; set; }
        public decimal TarifToutCompris { get; set; }
    
        public virtual AgenceVoyage AgenceVoyage { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual DossiersReservation DossiersReservation { get; set; }
    }
}
