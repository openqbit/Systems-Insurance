using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models.API
{
    public class ApiAccidentValueEstimationModel
    {
        public int ID { get; set; }
        public string Reason { get; set; }
        public double CostOfDamage { get; set; }
        public List<String> DamagedParts { get; set; }
    }
}