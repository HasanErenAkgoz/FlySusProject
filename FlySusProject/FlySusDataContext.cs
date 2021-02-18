using FlySusProject.Prop;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject
{
    class FlySusDataContext:DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<passangerInformation> passangerInformations { get; set; }
        public DbSet<adminlflightInformations> AdminlFlightInformations { get; set; }
        public DbSet<fullseat> fullseats { get; set; }
        public DbSet<emptyseat> emptyseats { get; set; }
    }
}
