using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    public class CoverageModel
    {
        public int ID { get; set; }
        public String CoverageType { get; set; }
        public String Includes { get; set; }
        public String Conditions { get; set; }

        public virtual PolicyTypeModel PolicyTypes { get; set; }
        public virtual ICollection<PolicyCoverageDetailModel> PolicyCoverageDetails { get; set; }
        
    }
}
