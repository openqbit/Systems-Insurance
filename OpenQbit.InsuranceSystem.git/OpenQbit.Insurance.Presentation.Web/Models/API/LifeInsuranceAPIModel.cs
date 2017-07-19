using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQbit.Insurance.Presentation.Web.Models.API.Contracts;


namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class LifeInsuranceAPIModel : IApiInsuranceTypeModel
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
        public ApiLifeInsuranceBeneficiaryModel Beneficiary { get; set; }
    }
}