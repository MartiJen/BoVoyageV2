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
    
    public partial class Client
    {
        public int IdClients { get; set; }
        public string Civilité { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Téléphone { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    
        public virtual DossiersReservation DossiersReservation { get; set; }
    }
}