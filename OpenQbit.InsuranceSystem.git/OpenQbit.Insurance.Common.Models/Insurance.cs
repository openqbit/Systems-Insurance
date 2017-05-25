using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    class Insurance
    {
        public int ID { get; set; }
        public int AgentID { get; set; }
        public int ClientID { get; set; }
        public DateTime Joining_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Decimal Total_Value { get; set; }
        public virtual Document document { get; set; }
    }
}
