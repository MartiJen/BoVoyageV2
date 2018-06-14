using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    class EntiteMetier
    {
        public int Id { get; set; }

        public string Nom { get; set; }
        public string Preom { get; set; }
        

        public override string ToString()
        {
            return $"{this.Nom} ({this.Id})";
        }
    }
}
