using OpenQbit.Insurance.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models.API
{
    public class ApiInsuranceModel
    {
        public enum InsuranceTypes
        {
            LIFE_INSURANCE,
            RE_INSURANCE,
            MOTOR_INSURANCE,
            MARINE_INSURANCE,
            FIRE_INSURANCE
        }
        public int ID { get; set; }
        public DateTime Joining_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Decimal Total_Value { get; set; }
        
        public InsuranceTypes InsuranceType { get; set; }
        public IApiInsuranceTypeModel SelectedInsurance { get; set; }
        public int AgentID { get; set; }

        public ApiClientModel Client { get; set; }
        public ApiDocumentModel Documents { get; set; }
        public ApiPolicyCoverageDetailModel PolicyDetails { get; set; }
        public ApiCoverageModel Coverage { get; set; }
    }
}