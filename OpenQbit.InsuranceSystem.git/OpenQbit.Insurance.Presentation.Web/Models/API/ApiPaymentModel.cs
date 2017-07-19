using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class ApiPaymentModel
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public string Date_and_time { get; set; }

        public int PolicyCoverageDetailID { get; set; }
    }
}