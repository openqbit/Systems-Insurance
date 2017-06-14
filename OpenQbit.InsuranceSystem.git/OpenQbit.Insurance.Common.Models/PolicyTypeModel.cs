using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    public enum PolicyTypes
    {
        ReInsurance,Fire,Motor,Life,Marine
    }

    public class PolicyTypeModel
    {
        public int ID { get; set; }
        public PolicyTypes Type { get; set; }
        public List<String> Eligibilities { get; set; }
        public ICollection<CoverageModel> coverages { get; set; }
    }


}
