using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject.Prop
{
    public class adminlflightInformations
    {
        [Key]
        public int flightsId { get; set; }
        public string departureAırport { get; set; }
        public string landingAırport { get; set; }
        public DateTime departureTıme { get; set; }
        public DateTime returnTıme { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

    }
}
