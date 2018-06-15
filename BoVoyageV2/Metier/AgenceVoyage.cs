using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    [Table("AgenceVoyage")]
    public class AgenceVoyage
    {
        [Key]
        public int IdAgenceVoyage { get; set; }
        public string Nom { get; set; }

        public override string ToString()
        {
            return Nom;
        }
    }
}
