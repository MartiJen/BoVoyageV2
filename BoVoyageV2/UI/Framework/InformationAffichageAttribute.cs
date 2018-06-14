using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.UI.Framework
{
    public sealed class InformationAffichageAttribute : Attribute
    {
        public int NombreCaracteres { get; set; }

        public string Entete { get; set; }
    }
}
