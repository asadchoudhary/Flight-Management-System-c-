using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End.Resources.model
{
    class Flight_Schedule
    {
        public DateTime flight_Time_Sch{get; set;}
        public DateTime flight_Date_Sch { get; set; }
        public string Flight_Departure { get; set; }
        public string Flight_Arrival { get; set; }
        public int Flight_Capacity { get; set; }
        public int flight_Booked_Seat { get; set; }



    }
}
