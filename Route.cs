using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
   class Route
    {
        protected string route_id;
        public string Route_id { set { route_id = value; } get { return route_id; } }

        protected string stay_time;
        public string Stay_time { set { stay_time = value; } get { return stay_time; } }

        protected string distance;
        public string Distance { set { distance = value; } get { return distance; } }
       public Route()
       {
           this.Route_id = "R109";
           this.Stay_time = "2 hours";
           this.Distance = "200KM";
        }
        public void ridfun()
        {
            
        }
    }
}
