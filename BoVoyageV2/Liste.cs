using BoVoyage.Framework.UI;
using BoVoyageV2.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2
{
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
