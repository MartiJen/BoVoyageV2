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

            var liste = new BaseDonnees().Clients.ToList();

            ConsoleHelper.AfficherListe(liste,Liste.strategieAffichageEntitesMetier);

            
        }

        private void AjouterClient()
        {
            ConsoleHelper.AfficherEntete("Nouveau client");
                        
            var client = new Client
            {
                Civilite = ConsoleSaisie.SaisirChaineObligatoire("Civilité : "),
                Nom = ConsoleSaisie.SaisirChaineObligatoire("Nom : "),
                Prenom = ConsoleSaisie.SaisirChaineObligatoire("Prénom : "),
                Adresse = ConsoleSaisie.SaisirChaineObligatoire("Adresse : "),
                Telephone = ConsoleSaisie.SaisirChaineObligatoire("Téléphone: "),
                DateNaissance = ConsoleSaisie.SaisirDateObligatoire("Date de naissance : "),
                Age = ConsoleSaisie.SaisirEntierObligatoire("Age : "),
                Email= ConsoleSaisie.SaisirChaineObligatoire("Email : "),

            };
            using (var bd = new BaseDonnees())
            {
                bd.Clients.Add(client);
                bd.SaveChanges();
            }

            Console.WriteLine("TO BE CONTINUED");          
                      
        }

        private void SupprimerClient()
        {
            ConsoleHelper.AfficherEntete("Supprimer client");

            var liste = new BaseDonnees().Clients.ToList();
            ConsoleHelper.AfficherListe(liste,Liste.strategieAffichageEntitesMetier);
            var id = ConsoleSaisie.SaisirEntierObligatoire("Id");

            using (var sup = new BaseDonnees())
            {
                var client = sup.Clients.Single(x => x.IdClients == id);
                sup.Clients.Remove(client);
                sup.SaveChanges();

            }

        }
    }
}
