using BoVoyage.Framework.UI;
using BoVoyageV2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.UI
{
    class ModuleGestionClient
    {
        private Menu menu;

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des clients");
            this.menu.AjouterElement(new ElementMenu("1", "Afficher les clients")
            {
                FonctionAExecuter = this.AfficherClients
            });
            this.menu.AjouterElement(new ElementMenu("2", "Ajouter un client")
            {
                FonctionAExecuter = this.AjouterClient
            });
            this.menu.AjouterElement(new ElementMenu("3", "Supprimer un client")
            {
                FonctionAExecuter = this.SupprimerClient
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

        private void AfficherClients()
        {
            ConsoleHelper.AfficherEntete("Clients");

            Console.WriteLine("TO DO");
        }

        private void AjouterClient()
        {
            ConsoleHelper.AfficherEntete("Nouveau client");

            //var client = new Client
            //{
            //    Nom = ConsoleSaisie.SaisirChaine("Nom : ", false),
            //    Prenom = ConsoleSaisie.SaisirChaine("Prénom : ", false),
            //    Adresse = ConsoleSaisie.SaisirChaine("Adresse : ", false)
            //};

            Console.WriteLine("TO BE CONTINUED");
        }

        private void SupprimerClient()
        {
            ConsoleHelper.AfficherEntete("Supprimer client");

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
    }
}
