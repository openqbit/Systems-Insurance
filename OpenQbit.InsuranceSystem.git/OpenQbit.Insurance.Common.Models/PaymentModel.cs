using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Test comment
namespace OpenQbit.Insurance.Common.Models
{
    public class PaymentModel
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public string Date { get; set; }

        public int PolicyCoverageDetailID { get; set; }

        public virtual PolicyCoverageDetailModel PolicyCoverageDetail { get; set; }
    }
}
