using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

       // public virtual PolicyCoverageDetailModel PolicyCoverageDetail { get; set; }

    }
}
