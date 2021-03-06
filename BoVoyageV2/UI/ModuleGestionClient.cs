﻿using BoVoyage.Framework.UI;
using BoVoyageV2.DAL;
using BoVoyageV2.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.UI
{
    public class ModuleGestionClient
    {
        private Menu menu;

        public ModuleGestionClient (Application application)
        {
            Application = application;
        }

        public Application Application { get; }

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des clients");
            this.menu.AjouterElement(new ElementMenu("1", "Liste des clients")
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
            this.menu.AjouterElement(new ElementMenu("4", "Liste des participants")
            {
                FonctionAExecuter = this.AfficherParticipants
            });
            this.menu.AjouterElement(new ElementMenu("5", "Gestion des dossier de reservation")
            {
                AfficherLigneRetourMenuApresExecution = false,
                FonctionAExecuter = this.Application.ModuleGestionDossierReservation.Demarrer
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

            ConsoleHelper.AfficherListe(liste, ListeClient.strategieAffichageEntitesMetier);            
        }

        private void AjouterClient()
        {
            ConsoleHelper.AfficherEntete("Nouveau client");

            using (var bd = new BaseDonnees())
            {
                var liste = new BaseDonnees().Clients.ToList();
                ConsoleHelper.AfficherListe(liste, ListeClient.strategieAffichageEntitesMetier);
                var client = new Client();

                //Pour que la saisie soit uniquement "M" ou "Mme" mais message "retour memu" après cette étape
                /*while(false)
                    {
                    client.Civilite = ConsoleSaisie.SaisirChaineObligatoire("Civilité : ");
                    if (client.Civilite == "M" || client.Civilite == "Mme")
                    { }
                    else
                    {
                        ConsoleHelper.AfficherMessageErreur("Saisie invalide");
                        return;
                    } }*/
                    
                client.Civilite = ConsoleSaisie.SaisirChaineObligatoire("Civilité : ");
                client.Nom = ConsoleSaisie.SaisirChaineObligatoire("Nom : ");
                client.Prenom = ConsoleSaisie.SaisirChaineObligatoire("Prénom : ");
                client.Adresse = ConsoleSaisie.SaisirChaineObligatoire("Adresse : ");
                client.Telephone = ConsoleSaisie.SaisirChaineObligatoire("Téléphone: ");
                client.DateNaissance = ConsoleSaisie.SaisirDateObligatoire("Date de naissance : ");
                if (client.DateNaissance > DateTime.Today)
                {
                    ConsoleHelper.AfficherMessageErreur("Date invalide");
                    return;
                }
                client.Email = ConsoleSaisie.SaisirChaineObligatoire("Email : ");
                
                bd.Clients.Add(client);
                bd.SaveChanges();
            }
        }       

        private void SupprimerClient()
        {
            ConsoleHelper.AfficherEntete("Supprimer client");

            var liste = new BaseDonnees().Clients.ToList();
            ConsoleHelper.AfficherListe(liste, ListeClient.strategieAffichageEntitesMetier);
            var id = ConsoleSaisie.SaisirEntierObligatoire("Id du client à supprimer");

            using (var sup = new BaseDonnees())
            {
                var client = sup.Clients.Single(x => x.IdClients == id);
                sup.Clients.Remove(client);
                sup.SaveChanges();
            }
        }

        private void AfficherParticipants()
        {
            ConsoleHelper.AfficherEntete("Participants");

            var liste = new BaseDonnees().Participants.ToList();

            ConsoleHelper.AfficherListe(liste, ListeParticipant.strategieAffichageEntitesMetier);            
        }
    }
}
