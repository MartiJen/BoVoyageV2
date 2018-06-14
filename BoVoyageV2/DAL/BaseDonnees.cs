using BoVoyageV2.Métier;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageV2.DAL
{
    class BaseDonnees : DbContext
    {
        public BaseDonnees(String connectionString = "Connexion")
            : base(connectionString)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<DossiersReservation> DossiersReservations { get; set; }
        public DbSet<Voyage> Voyages { get; set; }
        public DbSet<AgenceVoyage> AgenceVoyages { get; set; }
        public DbSet<Assurance> Assurances { get; set; }
        public DbSet<AssuranceAnnulation> AssuranceAnnulations { get; set; }


    }

}
