using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    class Document
    {
        public int ID { get; set; }
        public int InsuranceID { get; set; }
        public String Authuerisation { get; set; }
        public int Copy { get; set; }
        public virtual ICollection<Insurance> Insurance { get; set; }
    }
}
