using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End.Resources.model
{
    class Passenger:Person
    {
        public string passenger_passport_no { get; set; }
        public string passenger_email_address { get; set; }
        public string passenger_luggage_carried { get; set; }
    }
}
