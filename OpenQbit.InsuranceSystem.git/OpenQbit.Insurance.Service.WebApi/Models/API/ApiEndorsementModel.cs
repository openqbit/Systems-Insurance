using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models
{
    public class ApiEndorsementModel
    {
        public int ID { get; set; }
        public string Details { get; set; }
        public int PolicyCoverageDetailID { get; set; }

    }
}