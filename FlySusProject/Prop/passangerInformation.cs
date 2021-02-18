using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject.Prop
{
   public class passangerInformation
    {
        [Key]
        public string passengerTc { get; set; }
        public int PassangerCode { get; set; }
        public string passengerName { get; set; }
        public string passengerSurname { get; set; }
        public string passengerTelNo { get; set; }
        public string passengerAddress { get; set; }



    }
}
