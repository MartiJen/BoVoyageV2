using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class AssuranceAnnulation
    {
        public int IdAssuranceAnnulation { get; set; }

        public virtual Assurance Assurance { get; set; }
    }
}
