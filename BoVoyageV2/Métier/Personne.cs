using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class Personne
    {
        public string Civilité { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Téléphone { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public int Age { get; set; }
    }
}
