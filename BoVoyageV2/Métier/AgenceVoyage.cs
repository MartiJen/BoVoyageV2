﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.Métier
{
    public class AgenceVoyage
    {
        [Key]
        public int IdAgenceVoyage { get; set; }
        public string Nom { get; set; }

        public virtual Voyage Voyage { get; set; }
    }
}
