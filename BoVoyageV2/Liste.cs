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
        // On définit ici les propriétés qu'on veut afficher
        //  et la manière de les afficher
        private static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
            new List<InformationAffichage>
            {
                InformationAffichage.Creer<Voyage>(x=>x.IdVoyage, "Id", 3),
                InformationAffichage.Creer<Voyage>(x=>x.DateAller, "Date d'aller", 20),
                InformationAffichage.Creer<Voyage>(x=>x.DateRetour, "Date de retour", 20),
                InformationAffichage.Creer<Voyage>(x=>x.TarifToutCompris, "Tarif tout compris", 10),
            };
    }
}
