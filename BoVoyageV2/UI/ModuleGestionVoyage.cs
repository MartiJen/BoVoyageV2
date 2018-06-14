using BoVoyage.Framework.UI;
using BoVoyageV2.DAL;
using BoVoyageV2.UI.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.UI
{
    public class ModuleGestionVoyage
    {
        private Menu menu;

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des voyages");
            this.menu.AjouterElement(new ElementMenu("1", "Afficher les voyages")
            {
                FonctionAExecuter = this.AfficherVoyages
            });
            this.menu.AjouterElement(new ElementMenu("2", "Ajouter un voyage")
            {
                FonctionAExecuter = this.AjouterVoyages
            });
            this.menu.AjouterElement(new ElementMenu("3", "Supprimer un voyage")
            {
                FonctionAExecuter = this.SupprimerVoyages
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

        private void AfficherVoyages()
        {
            ConsoleHelper.AfficherEntete("Voyages");

            var liste = new BaseDonnees().Voyages.ToList();
            ConsoleHelper.AfficherListe(liste, strategieAffichageEntitesMetier);

        }

        private void AjouterVoyages()
        {
            ConsoleHelper.AfficherEntete("Nouveau Voyage");

            BaseDonnees context = new BaseDonnees();
            var voyage = new Voyage
            {
                DateAller = ConsoleSaisie.SaisirDateObligatoire("Date d'aller : "),
                DateRetour = ConsoleSaisie.SaisirDateObligatoire("Date de retour : "),
                PlacesDisponibles = ConsoleSaisie.SaisirEntierObligatoire("Places disponibles : "),
                TarifToutCompris = ConsoleSaisie.SaisirDecimalObligatoire("Tarif tout compris : ")
            };
            context.Voyages.Add(voyage);
            context.SaveChanges();

        }

        private void SupprimerVoyages()
        {
            ConsoleHelper.AfficherEntete("Supprimer voyages");

            //var liste = new BaseDonnees().Clients.ToList();
            //ConsoleHelper.AfficherListe(liste);
            //var id = ConsoleSaisie.SaisirEntierObligatoire("Id");

            //using (var sup = new BaseDonnees())
            //{
            //    var client = sup.Clients.Single(x => x.Id == id);
            //    sup.Clients.Remove(client);
            //    sup.SaveChanges();

            //}

        }

        private static SqlConnection GetConnexion()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connexion"].ConnectionString;
            return new SqlConnection(connectionString);
        }


    }

        
 

}
