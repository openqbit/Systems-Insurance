﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Test comment

namespace OpenQbit.Insurance.Common.Models
{
    public class AccidentValueEstimationModel
    {
        public int ID { get; set; }
        public String Reason { get; set; }
        public double CostOfDamage { get; set; }
        public List<String> DamagedParts { get; set; }

        public int ClaimModelID { get; set; }
    }
}
