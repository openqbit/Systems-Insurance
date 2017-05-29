using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models.API
{
    public class ApiCoverageModel
    {
        public int ID { get; set; }
        public string CoverageType { get; set; }
        public string Includes { get; set; }
        public string conditions { get; set; }
    }
}