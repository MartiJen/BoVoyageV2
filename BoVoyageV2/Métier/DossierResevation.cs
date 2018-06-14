using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class DossiersReservation
    {
        [Key]
        public int IdDossierRéservation { get; set; }
        public int NumeroUnique { get; set; }
        public string NumeroCarteBancaire { get; set; }
        public decimal PrixTotal { get; set; }

        public virtual Assurance Assurance { get; set; }
        public virtual Client Client { get; set; }
        public virtual Participant Participant { get; set; }
        public virtual Voyage Voyage { get; set; }
    }
}
