using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class Destination
    {
        public int IdDestination { get; set; }
        public string Continent { get; set; }
        public string Pays { get; set; }
        public string Région { get; set; }
        public string Description { get; set; }

        public virtual Voyage Voyage { get; set; }
    }
}
