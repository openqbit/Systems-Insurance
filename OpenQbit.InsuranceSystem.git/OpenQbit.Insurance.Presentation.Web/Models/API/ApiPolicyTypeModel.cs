using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public enum PolicyTypes
{
    ReInsurance, Fire, Motor, Life, Marine
}

    public class ApiPolicyTypeModel
    {
        public int ID { get; set; }
        public PolicyTypes Type { get; set; }
        public List<String> Eligibilities { get; set; }
    }
}