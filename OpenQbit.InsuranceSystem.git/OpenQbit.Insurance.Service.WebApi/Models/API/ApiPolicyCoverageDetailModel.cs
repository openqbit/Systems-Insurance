using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models.API
{
    public class ApiPolicyCoverageDetailModel
    {
        public int ID { get; set; }
        public double CoverageValue { get; set; }
        public double TotalPolicyValue { get; set; }
        public String Note { get; set; }

        public int InsuranceID { get; set; }
        public int CoverageID { get; set; }
    }
}