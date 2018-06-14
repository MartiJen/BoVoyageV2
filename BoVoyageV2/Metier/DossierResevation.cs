using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class DossiersReservation
    {
        [Key]
        public int IdDossierRéservation { get; set; }
        public int NuméroUnique { get; set; }
        public string NuméroCarteBancaire { get; set; }
        public decimal PrixTotal { get; set; }
               
        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }
        public int IdClient { get; set; }
                
        [ForeignKey("IdVoyage")]
        public virtual Voyage Voyage { get; set; }
        public int IdVoyage { get; set; }                 
             
    }
}
