using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenQbit.Insurance.Common.Models
{
    class LifeInsuranceModel : InsuranceModel
    {
        public enum TOBBACO_TYPES
        {
            CIGARETTES, CIGARS, OTHERS
        }

        public String Occupation { get; set; }
        public double AnnualIncome { get; set; }
        public double NetWorth { get; set; }
        public bool TobbacoUsingStatus { get; set; }
        public TOBBACO_TYPES? TobbacoTypesUsing { get; set; }
        public LifeInsuranceBeneficiaryModel Beneficiary { get; set; }
    }
}
