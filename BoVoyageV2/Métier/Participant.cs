using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class Participant : Personne
    {
        public int IdParticipant { get; set; }
        public int NuméroUnique { get; set; }
        public double Réduction { get; set; }

        public virtual DossiersReservation DossiersReservation { get; set; }
    }
}
