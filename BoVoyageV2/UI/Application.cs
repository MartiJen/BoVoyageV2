﻿using BoVoyage.Framework.UI;
using BoVoyageV2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.UI
{
    public class Application
    {
        private Menu menuPrincipal;
        private ModuleGestionClient moduleGestionClient;
        private ModuleGestionVoyage moduleGestionVoyage;

        private void InitialiserModules()
        {
            this.moduleGestionClient = new ModuleGestionClient();
            this.moduleGestionVoyage = new ModuleGestionVoyage();
        }

        private void InitialiserMenuPrincipal()
        {
            this.menuPrincipal = new Menu("Menu principal");
            this.menuPrincipal.AjouterElement(new ElementMenu("1", "Gestion des Clients")
            {
                AfficherLigneRetourMenuApresExecution = false,
                FonctionAExecuter = this.moduleGestionClient.Demarrer
            });
            this.menuPrincipal.AjouterElement(new ElementMenu("2", "Gestion des Voyages")
            {
                AfficherLigneRetourMenuApresExecution = false,
                FonctionAExecuter = this.moduleGestionVoyage.Demarrer
            });
            this.menuPrincipal.AjouterElement(new ElementMenuQuitterMenu("Q", "Quitter")
            {
                FonctionAExecuter = () => Environment.Exit(1)
            });
        }

        public void Demarrer()
        {
            this.InitialiserModules();
            this.InitialiserMenuPrincipal();

            this.menuPrincipal.Afficher();
        }

        /*public static BaseDonnees GetBaseDonnees()
        {
            return new BaseDonnees();
        }*/
    }
}
