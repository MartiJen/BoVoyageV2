using BoVoyage.Framework.UI;
using BoVoyageV2.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2
{
    class ListeClient
    {
        public static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
           new List<InformationAffichage>
           {
                InformationAffichage.Creer<Client>(x=>x.IdClients, "Id", 3),
                InformationAffichage.Creer<Client>(x=>x.Civilite, "Civilité", 8),
                InformationAffichage.Creer<Client>(x=>x.Nom, "Nom", 20),
                InformationAffichage.Creer<Client>(x=>x.Prenom, "Prénom", 20),
                InformationAffichage.Creer<Client>(x=>x.Adresse, "Adresse", 20),
                InformationAffichage.Creer<Client>(x=>x.Telephone, "Téléphone", 12),
                InformationAffichage.Creer<Client>(x=>x.DateNaissance, "Date de naissance", 20),
                InformationAffichage.Creer<Client>(x=>x.Age, "Age", 20),
                InformationAffichage.Creer<Client>(x=>x.Email, "Email", 20),
           };
    }

    class ListeParticipant
    {
        public static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
           new List<InformationAffichage>
           {
                InformationAffichage.Creer<Participant>(x=>x.IdNumeroUnique, "N° Participant", 15),
                InformationAffichage.Creer<Participant>(x=>x.Civilite, "Civilité", 8),
                InformationAffichage.Creer<Participant>(x=>x.Nom, "Nom", 20),
                InformationAffichage.Creer<Participant>(x=>x.Prenom, "Prénom", 20),
                InformationAffichage.Creer<Participant>(x=>x.Adresse, "Adresse", 20),
                InformationAffichage.Creer<Participant>(x=>x.Telephone, "Téléphone", 12),
                InformationAffichage.Creer<Participant>(x=>x.DateNaissance, "Date de naissance", 20),
                InformationAffichage.Creer<Participant>(x=>x.Age, "Age", 20),
           };
    }

    class ListeVoyage
    {

        public static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<Voyage>(x=>x.IdVoyage, "Id", 3),
                InformationAffichage.Creer<Voyage>(x=>x.Destination.Pays, "Pays", 15),
                InformationAffichage.Creer<Voyage>(x=>x.Destination.Description, "Description", 20),
                InformationAffichage.Creer<Voyage>(x=>x.DateAller, "Date d'aller", 15),
                InformationAffichage.Creer<Voyage>(x=>x.DateRetour, "Date de retour", 15),
                InformationAffichage.Creer<Voyage>(x=>x.TarifToutCompris, "Tarif tout compris", 20),
                InformationAffichage.Creer<Voyage>(x=>x.PlacesDisponibles, "Places disponibles", 20),
                InformationAffichage.Creer<Voyage>(x=>x.AgenceVoyage.Nom, "Agence", 20),
            };
    }

    class ListeDossierReservation
    {
        public static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
           new List<InformationAffichage>
           {
                InformationAffichage.Creer<DossiersReservation>(x=>x.IdNumeroUnique, "N° Dossier ", 15),
                InformationAffichage.Creer<DossiersReservation>(x=>x.IdClient, "N° Client", 15),
                InformationAffichage.Creer<DossiersReservation>(x=>x.NumeroCarteBancaire, "N° Carte Bancaire", 20),
                InformationAffichage.Creer<DossiersReservation>(x=>x.Voyage.Destination.Pays, "Pays", 20),
                InformationAffichage.Creer<DossiersReservation>(x=>x.Voyage.DateAller, "Date de départ", 15),
                InformationAffichage.Creer<DossiersReservation>(x=>x.PrixTotal, "PrixTotal", 10),
                InformationAffichage.Creer<DossiersReservation>(x=>x.Voyage.AgenceVoyage.Nom, "Agence", 20),
                InformationAffichage.Creer<DossiersReservation>(x=>x.NombreParticipant, "Nbre de Participants", 20),
                InformationAffichage.Creer<DossiersReservation>(x=>x.Assurance, "Assurance", 10),
           };
    }
}





    

