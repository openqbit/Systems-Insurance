using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    public class EndorsementModel
    {
        public int ID { get; set; }
        public string Details { get; set; }
        public int PolicyCoverageDetailID { get; set; }
        public virtual PolicyCoverageDetailModel PolicyCoverageDetail { get; set; }
    }
}
