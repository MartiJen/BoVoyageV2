using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    [Table("Clients")]
    public class Client : Personne
    {
        [Key]
        public int IdClients { get; set; }
        public string Email { get; set; }                      
    }
}
