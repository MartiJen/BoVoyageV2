using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class DossiersReservation
    {
        public int IdDossierRéservation { get; set; }
        public int NuméroUnique { get; set; }
        public string NuméroCarteBancaire { get; set; }
        public decimal PrixTotal { get; set; }

        public virtual Assurance Assurance { get; set; }
        public virtual Client Client { get; set; }
        public virtual Participant Participant { get; set; }
        public virtual Voyage Voyage { get; set; }
    }
}
