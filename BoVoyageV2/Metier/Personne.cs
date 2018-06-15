using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class Personne
    {
        
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public int Age
            { get
                { return (DateTime.Today - DateNaissance).Days / 365;
                }
            }
    }
}
