using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;


namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class ClaimController : ApiController
    {
        public bool Add(ApiClaimModel claim)
        {
            return true;
        }

        public bool Update(ApiClaimModel claim)
        {
            return true;
        }

        public ApiClaimModel Get(int? ID)
        {
            ApiClaimModel claim = new ApiClaimModel
            {
                ID = (int)ID,
                ClaimValue=25000,
                EstimatedDamage=3450,
                Note="Damage Covered"
            };

            return claim;
        }

        public List<ApiClaimModel> GetList()
        {
            List<ApiClaimModel> claimList = new List<ApiClaimModel>();

            ApiClaimModel claim1 = new ApiClaimModel
            {
                ID = 1,
                ClaimValue=25000,
                EstimatedDamage=3450,
                Note="Damage Covered"
            };
            claimList.Add(claim1);

            ApiClaimModel claim2 = new ApiClaimModel
            {
                ID = 2,
                ClaimValue=32000,
                EstimatedDamage=1250,
                Note="Pending"
            };
            claimList.Add(claim2);
            return claimList;
        }
    }
}
