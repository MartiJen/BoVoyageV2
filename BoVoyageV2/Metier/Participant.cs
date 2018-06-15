using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    [Table("Participants")]
    public class Participant : Personne
    {
        [Key]
        public int IdNumeroUnique { get; set; }        
        public double Reduction { get; set; }

        [ForeignKey("IdDossierReservation")]
        public virtual DossiersReservation DossiersReservation { get; set; }
        public int IdDossierReservation { get; set; }
    }
}

