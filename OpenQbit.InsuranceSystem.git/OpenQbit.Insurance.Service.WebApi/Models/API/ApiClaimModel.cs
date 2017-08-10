using OpenQbit.Insurance.Service.WebApi.Models.API.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models.API
{
    public class ApiClaimModel
    {

        public int ID { get; set; }
        public double ClaimValue { get; set; }
        public double EstimatedDamage { get; set; }
        public string Note { get; set; }
        public int policyCoverageDetailID { get; set; }

        public ApiClientModel Client { get; set; }
        public ApiAgentModel Agent { get; set; }
        public ApiAccidentValueEstimationModel AccidentValueEstimaton { get; set; }



    }
}