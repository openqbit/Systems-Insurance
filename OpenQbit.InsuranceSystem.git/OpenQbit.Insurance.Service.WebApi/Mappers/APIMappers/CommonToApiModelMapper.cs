using OpenQbit.Insurance.Common.Models;
using OpenQbit.Insurance.Service.WebApi.Models;
using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Mappers.APIMappers
{
    public class CommonToApiModelMapper
    {
        public ApiAccidentValueEstimationModel MapAccidentValueEstmationCommonModel(AccidentValueEstimationModel ave)
        {
            return new ApiAccidentValueEstimationModel()
            {
                ID = ave.ID,
                CostOfDamage = ave.CostOfDamage,
                DamagedParts = ave.DamagedParts,
                Reason = ave.Reason,
            };
        }

        public ApiAgentModel MapAgentCommonModel(AgentModel agent)
        {
            return new ApiAgentModel()
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

        public ApiClaimModel MapClaimCommonModel(ClaimModel claim)
        {
            return new ApiClaimModel()
            {
                ID = claim.ID,
                ClaimValue = claim.ClaimValue,
                EstimatedDamage = claim.EstimatedDamage,
                Note = claim.Note
            };
        }

        public ApiClientModel MapClientCommonModel(ClientModel client)
        {
            return new ApiClientModel()
            {
                ID = client.ID,
                First_Name = client.First_Name,
                Last_Name = client.Last_Name,
                Address = client.Address,
                Date_of_Birth = client.Date_of_Birth,
                Age = client.Age,
                BloodGroup = (ApiClientModel.BloodGroups)client.BloodGroup,
                Email = client.Email,
                Gender = (ApiClientModel.Genders)client.Gender,
                Middle_Name = client.Middle_Name,
                Mobile = client.Mobile,
                Nationality = client.Nationality,
                Religion = client.Religion,
                Telephone = client.Telephone
            };
        }

        public ApiCoverageModel MapCoverageCommonModel(CoverageModel coverage)
        {
            return new ApiCoverageModel()
            {
                ID = coverage.ID,
                CoverageType = coverage.CoverageType,
                conditions = coverage.Conditions,
                Includes = coverage.Includes
            };
        }

        public ApiDocumentModel MapDocumentCommonModel(DocumentModel document)
        {
            return new ApiDocumentModel()
            {
                ID = document.ID,
                Document = document.Document,
                Authuorization = document.Authuorization,
                InsuranceID = document.InsuranceID
            };
        }

        public ApiEndorsementModel MapEndorsementCommonModel(EndorsementModel endorsement)
        {
            return new ApiEndorsementModel()
            {
                ID = endorsement.ID,
                Details = endorsement.Details,
                PolicyCoverageDetailID = endorsement.PolicyCoverageDetailID                
            };
        }

        public ApiFireInsuranceModel MapFireInsuranceCommonModel(FireInsuranceModel fireInsurance)
        {
            return new ApiFireInsuranceModel()
            {
                

            };
        }

        public ApiLifeInsuranceModel MapLifeInsuranceCommonModel(LifeInsuranceModel lifeInsurance)
        {
            return new ApiLifeInsuranceModel()
            {
                AnnualIncome = lifeInsurance.AnnualIncome,
                Beneficiary = MapLifeInsuranceBeneficiaryCommonModel(lifeInsurance.Beneficiary),
                NetWorth = lifeInsurance.NetWorth,
                Occupation = lifeInsurance.Occupation,
                TobbacoTypesUsing = (ApiLifeInsuranceModel.TOBBACO_TYPES)lifeInsurance.TobbacoTypesUsing,
                TobbacoUsingStatus = lifeInsurance.TobbacoUsingStatus
            };
        }

        public ApiLifeInsuranceBeneficiaryModel MapLifeInsuranceBeneficiaryCommonModel(LifeInsuranceBeneficiaryModel beneficiary)
        {
            return new ApiLifeInsuranceBeneficiaryModel()
            {
                BeneficiaryName = beneficiary.BeneficiaryName,
                Dob = beneficiary.Dob,
                NIC = beneficiary.NIC,
                RelationshipForTheClient = (ApiLifeInsuranceBeneficiaryModel.RelationshipTypes)beneficiary.RelationshipForTheClient
            };
        }

        public ApiItemModel MapItemCommonModel(ItemModel item)
        {
            return new ApiItemModel()
            {
                ID = item.ID,
                Name = item.Name,
                Brand = item.Brand,
                PolicyCoverageDetailID = item.PolicyCoverageDetailID,
                Value = item.Value
            };
        }

        public ApiMarineInsuranceModel MapMarineInsuranceCommonModel(MarineInsuranceModel insurance)
        {
            return new ApiMarineInsuranceModel()
            {
                
            };
        }

        public ApiMotorInsuranceModel MapMotorInsuranceCommonModel(MotorInsuranceModel insurance)
        {
            return new ApiMotorInsuranceModel()
            {

            };
        }

        public ApiPaymentModel MapPaymentCommonModel(PaymentModel payment)
        {
            return new ApiPaymentModel()
            {
                ID = payment.ID,
                Amount = payment.Amount,
                Date_and_time = payment.Date,
                PolicyCoverageDetailID = payment.PolicyCoverageDetailID
            };
        }

        public ApiPolicyCoverageDetailModel MapPolicyCoverageDetailCommonModel(PolicyCoverageDetailModel coverage)
        {
            return new ApiPolicyCoverageDetailModel()
            {
                ID = coverage.ID,
                CoverageID = coverage.CoverageID,
                CoverageValue = coverage.CoverageValue,
                InsuranceID = coverage.InsuranceID,
                Note = coverage.Note,
                TotalPolicyValue = coverage.TotalPolicyValue
            };
        }

        public ApiPolicyTypeModel MapPolicyTypeCommonModel(PolicyTypeModel policyType)
        {
            return new ApiPolicyTypeModel()
            {
                ID = policyType.ID,
                Eligibilities = policyType.Eligibilities,
                //Type = (PolicyTypes)policyType.Type
            };
        }

        public ApiReInsuranceModel MapReInsuranceCommonModel(ReInsuranceModel reInsurance)
        {
            return new ApiReInsuranceModel()
            {
            };
        }
    }
}