using BoVoyage.Framework.UI;
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
        }

        private void InitialiserMenuPrincipal()
        {
            this.menuPrincipal = new Menu("Menu principal");
            this.menuPrincipal.AjouterElement(new ElementMenu("1", "Gestion 1")
            {
                AfficherLigneRetourMenuApresExecution = false,
                FonctionAExecuter = this.moduleGestionClient.Demarrer
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
    }
}
