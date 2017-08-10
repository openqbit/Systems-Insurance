using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;
using OpenQbit.Insurance.BusinessService.Contracts;
using Microsoft.Practices.Unity;
using OpenQbit.Insurance.Common.Ioc;
using OpenQbit.Insurance.Service.WebApi.Mappers.APIMappers;
using OpenQbit.Insurance.Common.Models;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class ClaimController : ApiController
    {
        private IClaimManager _claimManager = UnityResolver.Resolve<IClaimManager>();
        
        public HttpResponseMessage Post(ApiClaimModel claim)
        {
            APIModelMapper m = new APIModelMapper();
            AccidentValueEstimationModel accidentValueEstimation = m.MapAccidentValueEstimationApiModel(claim.AccidentValueEstimaton);
            ClaimModel claimModel = m.MapClaimApiModel(claim);
            if (_claimManager.Record(accidentValueEstimation,claimModel)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiClaimModel claim)
        {
            if (_claimManager.Update(claim)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(ApiClaimModel claim)
        {
            if (_claimManager.Delete(claim)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiClaimModel Get(String id)
        {
            

            ClaimModel claim = _claimManager.Find<ClaimModel>(e => e.ID.Equals(id));

            CommonToApiModelMapper mapper = new CommonToApiModelMapper();
            return mapper.MapClaimCommonModel(claim);
        }

        public List<ApiClaimModel> GetList()
        {
            /*List<ApiClaimModel> claimList = new List<ApiClaimModel>();

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
            return claimList;*/

            return _claimManager.GetAll<ApiClaimModel>();
        }
    }
}
