using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class ApiClaimModel
    {
        public int ID { get; set; }
        public double ClaimValue { get; set; }
        public double EstimatedDamage { get; set; }
        public string Note { get; set; }
    }
}