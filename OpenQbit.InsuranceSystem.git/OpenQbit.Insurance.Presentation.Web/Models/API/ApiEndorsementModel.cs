using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class ApiEndorsementModel
    {
        public int ID { get; set; }
        public string Details { get; set; }
        public int PolicyCoverageDetailID { get; set; }
    }
}