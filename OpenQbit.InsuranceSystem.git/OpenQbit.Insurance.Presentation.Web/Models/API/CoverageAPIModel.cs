using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class CoverageAPIModel
    {
        public int ID { get; set; }
        public String CoverageType { get; set; }
        public String Includes { get; set; }
        public String Conditions { get; set; }
    }
}