using BoVoyage.Framework.UI;
using BoVoyageV2.DAL;
using BoVoyageV2.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.UI
{
    public class ModuleGestionDossierReservation
    {
        private Menu menu;

        public ModuleGestionDossierReservation(Application application)
        {
            Application = application;
        }

        public Application Application { get;  }

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des dossiers de réservation");
            this.menu.AjouterElement(new ElementMenu("1", "Suivi des dossier de resevation")
            {
                FonctionAExecuter = this.SuiviDossier
            });
            this.menu.AjouterElement(new ElementMenu("2", "Supprimer un dossier de reservation")
            {
                FonctionAExecuter = this.SupprimerDossier
            });
            this.menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        public void Demarrer()
        {
            if (this.menu == null)
            {
                this.InitialiserMenu();
            }

            this.menu.Afficher();
        }

        private void SuiviDossier()
        {
            ConsoleHelper.AfficherEntete("Dossier de reservation");

            var liste = new BaseDonnees().DossiersReservation.ToList();
            ConsoleHelper.AfficherListe(liste, ListeDossierReservation.strategieAffichageEntitesMetier);            
        }

        private void SupprimerDossier()
        {
            ConsoleHelper.AfficherEntete("Supprimer dossier de reservation");

            var liste = new BaseDonnees().DossiersReservation.ToList();
            ConsoleHelper.AfficherListe(liste, ListeDossierReservation.strategieAffichageEntitesMetier);
            var id = ConsoleSaisie.SaisirEntierObligatoire("N° de dossier à supprimer");

            using (var sup = new BaseDonnees())
            {
                var dossierReservation = sup.DossiersReservation.Single(x => x.IdNumeroUnique == id);
                sup.DossiersReservation.Remove(dossierReservation);
                sup.SaveChanges();
            }
        }      
    }
}
