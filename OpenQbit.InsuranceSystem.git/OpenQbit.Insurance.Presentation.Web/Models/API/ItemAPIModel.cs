using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class ItemAPIModel
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public int PolicyCoverageDetailID { get; set; }
    }
}