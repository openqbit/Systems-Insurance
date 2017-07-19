using OpenQbit.Insurance.Common.Models;
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
                Reason = ave.Reason
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
    }
}