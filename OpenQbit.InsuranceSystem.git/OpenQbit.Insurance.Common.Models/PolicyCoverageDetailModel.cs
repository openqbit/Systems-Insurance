﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Test comment
namespace OpenQbit.Insurance.Common.Models
{
    public class PolicyCoverageDetailModel
    {
        public int ID { get; set; }
        public double CoverageValue { get; set; }
        public double TotalPolicyValue { get; set; }
        public String Note { get; set; }

        public int InsuranceID { get; set; }
        public int CoverageID { get; set; }

        public virtual InsuranceModel Insurance { get; set; }
        public virtual CoverageModel Coverage { get; set; }

    }
}
