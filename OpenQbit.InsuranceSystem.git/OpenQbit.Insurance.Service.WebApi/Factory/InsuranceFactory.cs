using OpenQbit.Insurance.Common.Models;
using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Factory
{
    public class InsuranceFactory
    {
        private static InsuranceFactory instance;
        private InsuranceFactory() {
            
        }

        public static InsuranceFactory GetInstance() {
            if (instance == null)
            {
                instance = new InsuranceFactory();
            }
            return instance;
        }

        public InsuranceModel GetInsuranceModel(ApiInsuranceModel insurance)
        {
            switch (insurance.InsuranceType)
            {
                case ApiInsuranceModel.InsuranceTypes.LIFE_INSURANCE:
                    ApiLifeInsuranceModel lifeInsurance = (ApiLifeInsuranceModel)insurance.SelectedInsurance;
                    return new LifeInsuranceModel() {
                        AgentID = insurance.AgentID,
                        ClientID = insurance.Client.ID,
                        ID = insurance.ID,
                        End_Date = insurance.End_Date,
                        Joining_Date = insurance.Joining_Date,
                        Total_Value = insurance.Total_Value,
                        AnnualIncome = lifeInsurance.AnnualIncome,
                        Beneficiary = new LifeInsuranceBeneficiaryModel(lifeInsurance.Beneficiary.RelationshipForTheClient),

                        
                    };
                case ApiInsuranceModel.InsuranceTypes.RE_INSURANCE:
                    return new ReInsuranceModel();
                default:return null;
            }
        }
    }
}