using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class Assurance
    {
        public int IdAssurance { get; set; }

        public virtual AssuranceAnnulation AssuranceAnnulation { get; set; }
        public virtual DossiersReservation DossiersReservation { get; set; }
    }
}
