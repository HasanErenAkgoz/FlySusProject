using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject.Prop
{
   public class Flight
    {
        [Key]
        public string PnrCode { get; set; }
        public string Departure { get; set; }
        public string arrival { get; set; }
        public DateTime goingTime { get; set; }
        public DateTime returnTime { get; set; }
        public string adultTicket { get; set; }
        public string studentTicket { get; set; }
        public string armchair { get; set; }
        public int ticketPrice { get; set; }
        public DateTime rezTime { get; set; }
        public string status { get; set; }
     


    }
}
