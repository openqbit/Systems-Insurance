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
        public string CoverageType { get; set; }
        public string Includes { get; set; }
        public string Conditions { get; set; }

        public virtual PolicyTypeModel PolicyTypes { get; set; }
        
    }
}
