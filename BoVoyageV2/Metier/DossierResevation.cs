using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    [Table("DossiersReservation")]
    public class DossiersReservation
    {
        [Key]
        public int IdNumeroUnique { get; set; }        
        public string NumeroCarteBancaire { get; set; }
        public decimal PrixTotal { get; set; }

        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }
        public int IdClient { get; set; }

        [ForeignKey("IdVoyage")]
        public virtual Voyage Voyage { get; set; }
        public int IdVoyage { get; set; }

    }

    public enum EtatDossierReservation : byte
    {
        enAttente = 0,
        encours = 1,
        refusee = 2,
        Acceptee = 3
    }

    public enum RaisonAnnulatoionDossier : byte
    {
        client = 0,
        placesInsuffisantes = 2
    }

    
    
}
