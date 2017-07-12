using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class PolicyCoverageDetailAPIModel
    {
        public int ID { get; set; }
        public double CoverageValue { get; set; }
        public double TotalPolicyValue { get; set; }
        public String Note { get; set; }
    }
}