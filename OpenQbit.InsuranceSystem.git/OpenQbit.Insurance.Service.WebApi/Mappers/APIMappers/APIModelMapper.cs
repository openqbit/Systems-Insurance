using OpenQbit.Insurance.Common.Models;
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

    }
}