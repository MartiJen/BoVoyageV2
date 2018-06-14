using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class Voyage
    {
        public int IdVoyage { get; set; }
        public System.DateTime DateAller { get; set; }
        public System.DateTime DateRetour { get; set; }
        public int PlacesDisponibles { get; set; }
        public decimal TarifToutCompris { get; set; }

        public virtual AgenceVoyage AgenceVoyage { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual DossiersReservation DossiersReservation { get; set; }
    }
}
