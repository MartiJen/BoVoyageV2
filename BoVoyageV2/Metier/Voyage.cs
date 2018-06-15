using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    [Table("Voyages")]
    public class Voyage
    {
        [Key]
        public int IdVoyage { get; set; }
        public System.DateTime DateAller { get; set; }
        public System.DateTime DateRetour { get; set; }
        public int PlacesDisponibles { get; set; }
        public decimal TarifToutCompris { get; set; }

        [ForeignKey("IdAgenceVoyage")]
        public virtual AgenceVoyage AgenceVoyage { get; set; }
        public int IdAgenceVoyage { get; set; }

        [ForeignKey("IdDestination")]
        public virtual Destination Destination { get; set; }                 
        public int IdDestination { get; set; }        
    }
}
