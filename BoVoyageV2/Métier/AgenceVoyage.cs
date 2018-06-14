using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class AgenceVoyage
    {
        public int IdAgenceVoyage { get; set; }
        public string Nom { get; set; }

        public virtual Voyage Voyage { get; set; }
    }
}
