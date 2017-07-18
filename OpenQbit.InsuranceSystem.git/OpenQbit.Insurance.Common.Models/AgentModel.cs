using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    public class AgentModel
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public int Telephone { get; set; }

    }
}
