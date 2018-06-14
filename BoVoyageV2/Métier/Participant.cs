using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class Participant : Personne
    {
        [Key]
        public int IdParticipant { get; set; }
        public int NumeroUnique { get; set; }
        public double Reduction { get; set; }

        public virtual DossiersReservation DossiersReservation { get; set; }
    }
}
