using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Test comment
namespace OpenQbit.Insurance.Common.Models
{
    public class ClaimModel
    {
        public int ID { get; set; }
        public double ClaimValue { get; set; }
        public double EstimatedDamage { get; set; }
        public String Note { get; set; }

        public int PolicyCoverageDetailModelID { get; set; }

        public virtual PolicyCoverageDetailModel PolicyCoverageDetail { get; set; }
        public virtual AccidentValueEstimationModel AccidentValueEstimation { get; set; }
    }
}
