using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class Client : Personne
    {
        [Key]
        public int IdClients { get; set; }
        public string Email { get; set; }

        public virtual DossiersReservation DossiersReservation { get; set; }
    }
}
