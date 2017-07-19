using OpenQbit.Insurance.Common.Models;
using OpenQbit.Insurance.Service.WebApi.Models;
using OpenQbit.Insurance.Service.WebApi.Models.API;
using OpenQbit.Insurance.Service.WebApi.Models.API.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Mappers.APIMappers
{
    public class APIModelMapper
    {
        public InsuranceModel MapInsuranceTypeModel(ApiInsuranceModel.InsuranceTypes type, ApiInsuranceModel insurance, IApiInsuranceTypeModel selectedInsuranceType)
        {
            switch (type)
            {
                case ApiInsuranceModel.InsuranceTypes.LIFE_INSURANCE:
                    ApiLifeInsuranceModel lifeInsurance = (ApiLifeInsuranceModel)selectedInsuranceType;
                    return new LifeInsuranceModel()
                    {
                        ID = insurance.ID,
                        AgentID = insurance.AgentID,
                        ClientID = insurance.Client.ID,
                        End_Date = insurance.End_Date,
                        Joining_Date = insurance.Joining_Date,
                        Total_Value = insurance.Total_Value,
                        AnnualIncome = lifeInsurance.AnnualIncome,
                        NetWorth = lifeInsurance.NetWorth,
                        Occupation = lifeInsurance.Occupation,
                        TobbacoTypesUsing = (LifeInsuranceModel.TOBBACO_TYPES)lifeInsurance.TobbacoTypesUsing,
                        TobbacoUsingStatus = lifeInsurance.TobbacoUsingStatus,
                        Beneficiary = MapBeneficiaryModel(lifeInsurance.Beneficiary)
                    };
                    default:return null;
            }
        }

        public LifeInsuranceBeneficiaryModel MapBeneficiaryModel(ApiLifeInsuranceBeneficiaryModel beneficiary)
        {
            return new LifeInsuranceBeneficiaryModel()
            {
                BeneficiaryName = beneficiary.BeneficiaryName,
                Dob = beneficiary.Dob,
                NIC = beneficiary.NIC,
                RelationshipForTheClient = (LifeInsuranceBeneficiaryModel.RelationshipTypes)beneficiary.RelationshipForTheClient
            };
        }

        


        public ClientModel MapClientModel(ApiClientModel client)
        {
            return new ClientModel()
            {
                ID = client.ID,
                First_Name = client.First_Name,
                Last_Name = client.Last_Name,
                Address = client.Address,
                Date_of_Birth = client.Date_of_Birth,
                Age = client.Age,
                BloodGroup = (ClientModel.BloodGroups)client.BloodGroup,
                Email = client.Email,
                Gender = (ClientModel.Genders)client.Gender,
                Middle_Name = client.Middle_Name,
                Mobile = client.Mobile,
                Nationality = client.Nationality,
                Religion = client.Religion,
                Telephone = client.Telephone
            };
        }

        public DocumentModel MapDocumentModel(ApiDocumentModel document)
        {
            return new DocumentModel()
            {
                ID = document.ID,
                Authuorization = document.Authuorization,
                Document = document.Document,
                InsuranceID= document.InsuranceID
            };
        }

        public CoverageModel MapCoverage(ApiCoverageModel coverage)
        {
            return new CoverageModel()
            {
                ID = coverage.ID,
                Conditions = coverage.conditions,
                CoverageType = coverage.CoverageType,
                Includes = coverage.Includes
            };
        }

        public PolicyCoverageDetailModel MapPolicyCoverageDetailModel(ApiPolicyCoverageDetailModel policyCoverage)
        {
            return new PolicyCoverageDetailModel()
            {
                ID = policyCoverage.ID,
                CoverageID = policyCoverage.CoverageID,
                CoverageValue = policyCoverage.CoverageValue,
                InsuranceID = policyCoverage.InsuranceID,
                Note = policyCoverage.Note,
                TotalPolicyValue = policyCoverage.TotalPolicyValue
            };
        }

        public AccidentValueEstimationModel MapAccidentValueEstimationApiModel(ApiAccidentValueEstimationModel ave)
        {
            return new AccidentValueEstimationModel()
            {
                ID = ave.ID,
                CostOfDamage = ave.CostOfDamage,
                DamagedParts = ave.DamagedParts,
                Reason = ave.Reason
            };
        }

        public AgentModel MapAgentApiModel(ApiAgentModel agent)
        {
            return new AgentModel()
            {
                ID = agent.ID,
                First_Name = agent.First_Name,
                Last_Name = agent.Last_Name,
                Age = agent.Age,
                Date_of_Birth = agent.Date_of_Birth,
                Address = agent.Address,
                Email = agent.Email,
                Mobile = agent.Mobile,
                Telephone = agent.Telephone
            };
        }

        public ClaimModel MapClaimApiModel(ApiClaimModel claim)
        {
            return new ClaimModel()
            {
                ID = claim.ID,
                ClaimValue = claim.ClaimValue,
                EstimatedDamage = claim.EstimatedDamage,
                Note = claim.Note
            };
        }

        public EndorsementModel MapEndorsementApiModel(ApiEndorsementModel endorsement)
        {
            return new EndorsementModel()
            {
                ID = endorsement.ID,
                Details = endorsement.Details,
                PolicyCoverageDetailID = endorsement.PolicyCoverageDetailID
            };
        }

        public ApiFireInsuranceModel MapFireInsuranceApiModel(FireInsuranceModel fireInsurance)
        {
            return new ApiFireInsuranceModel()
            {


            };
        }

        public LifeInsuranceModel MapLifeInsuranceApiModel(ApiLifeInsuranceModel lifeInsurance)
        {
            return new LifeInsuranceModel()
            {
                AnnualIncome = lifeInsurance.AnnualIncome,
                Beneficiary = MapBeneficiaryModel(lifeInsurance.Beneficiary),
                NetWorth = lifeInsurance.NetWorth,
                Occupation = lifeInsurance.Occupation,
                TobbacoTypesUsing = (LifeInsuranceModel.TOBBACO_TYPES)lifeInsurance.TobbacoTypesUsing,
                TobbacoUsingStatus = lifeInsurance.TobbacoUsingStatus
            };
        }

        public ItemModel MapItemApiModel(ApiItemModel item)
        {
            return new ItemModel()
            {
                ID = item.ID,
                Name = item.Name,
                Brand = item.Brand,
                PolicyCoverageDetailID = item.PolicyCoverageDetailID,
                Value = item.Value
            };
        }

        public MarineInsuranceModel MapMarineInsuranceApiModel(ApiMarineInsuranceModel insurance)
        {
            return new MarineInsuranceModel()
            {

            };
        }

        public MotorInsuranceModel MapMotorInsuranceApiModel(ApiMotorInsuranceModel insurance)
        {
            return new MotorInsuranceModel()
            {

            };
        }

        public PaymentModel MapPaymentApiModel(ApiPaymentModel payment)
        {
            return new PaymentModel()
            {
                ID = payment.ID,
                Amount = payment.Amount,
                Date = payment.Date_and_time,
                PolicyCoverageDetailID = payment.PolicyCoverageDetailID
            };
        }

        public PolicyTypeModel MapPolicyTypeApiModel(ApiPolicyTypeModel policyType)
        {
            return new PolicyTypeModel()
            {
                ID = policyType.ID,
                Eligibilities = policyType.Eligibilities,
                //Type = (PolicyTypes)policyType.Type
            };
        }

        public ReInsuranceModel MapReInsuranceApiModel(ApiReInsuranceModel reInsurance)
        {
            return new ReInsuranceModel()
            {
            };
        }

    }
}