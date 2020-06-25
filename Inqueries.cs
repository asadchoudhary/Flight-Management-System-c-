using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    class Inqueries
    {
        protected string Inq_id;
        public string inq_id { set { Inq_id = value; } get { return Inq_id; } }
        protected string Inq_title;
        public string inq_title { set { Inq_title = value; } get { return Inq_title; } }
        protected string Inq_date;
        public string inq_date { set { Inq_date = value; } get { return Inq_date; } }
        protected string Inq_type;
        public string inq_type { set { Inq_type = value; } get { return Inq_type; } }
        protected string Inq_description;
        public string inq_description { set { Inq_description = value; } get {return Inq_description ;} }

        public Inqueries()
        {
            this.inq_id = "D1032";
            this.inq_title = "cabin attendent was rude";
            this.inq_type = "misbehave";
            this.inq_description = "Last day when i was traveling from lahore to islamabad in flight Pk16 the cabin attendent misbehaved me";
        }
    }
}
