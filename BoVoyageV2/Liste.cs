﻿using BoVoyage.Framework.UI;
using BoVoyageV2.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2
{
    class ListeVoyage
    {
        // On définit ici les propriétés qu'on veut afficher
        //  et la manière de les afficher
        public static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<Voyage>(x=>x.IdVoyage, "Id", 3),
                InformationAffichage.Creer<Voyage>(x=>x.DateAller, "Date d'aller", 20),
                InformationAffichage.Creer<Voyage>(x=>x.DateRetour, "Date de retour", 20),
                InformationAffichage.Creer<Voyage>(x=>x.TarifToutCompris, "Tarif tout compris", 10),
            };
    }


    class Liste
    {
        public static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
           new List<InformationAffichage>
           {
                InformationAffichage.Creer<Client>(x=>x.IdClients, "Id", 3),
                InformationAffichage.Creer<Client>(x=>x.Civilite, "Civilité", 8),
                InformationAffichage.Creer<Client>(x=>x.Nom, "Nom", 20),
                InformationAffichage.Creer<Client>(x=>x.Prenom, "Préom", 20),
                InformationAffichage.Creer<Client>(x=>x.Adresse, "Adresse", 20),
                InformationAffichage.Creer<Client>(x=>x.Telephone, "Téléphone", 12),
                InformationAffichage.Creer<Client>(x=>x.DateNaissance, "Date de naissance", 20),
                InformationAffichage.Creer<Client>(x=>x.Age, "Age", 5),
                InformationAffichage.Creer<Client>(x=>x.Email, "Email", 20),
           };
    }
}





    

