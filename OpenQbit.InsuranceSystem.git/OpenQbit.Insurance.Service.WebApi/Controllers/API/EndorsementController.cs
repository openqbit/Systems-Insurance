using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Common.Ioc;
using OpenQbit.Insurance.BusinessService.Contracts;
using Microsoft.Practices.Unity;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class EndorsementController : ApiController
    {

         IEndorsementManager _endorsementManager = UnityResolver.Resolve<IEndorsementManager>();

        public HttpResponseMessage Post(ApiEndorsementModel accident)
        {
            if (_endorsementManager.Recored(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiEndorsementModel accident)
        {
            if (_endorsementManager.Update(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }

        public HttpResponseMessage Delete(ApiEndorsementModel accident)
        {
            if (_endorsementManager.Delete(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiEndorsementModel Get(ApiEndorsementModel accident)
        {
            /*ApiEndorsementModel endorsement = new ApiEndorsementModel
            {
                //ID = (int)ID,
                //Details = "Nothing",
                //PolicyCoverageDetailID = 1
            };

            return endorsement;*/
            return _endorsementManager.Find<ApiEndorsementModel>(e => e.ID == accident.ID);

        }

        public List<ApiEndorsementModel> GetList()
        {
            /*List<ApiEndorsementModel> endorsementList = new List<ApiEndorsementModel>();
            ApiEndorsementModel endorsement1 = new ApiEndorsementModel
            {
                //ID = 1,
                //Details = "Nothing",
                //PolicyCoverageDetailID = 1
            };
            endorsementList.Add(endorsement1);

            ApiEndorsementModel endorsement2 = new ApiEndorsementModel
            {
                //ID = 2,
                //Details = "Nothing",
                //PolicyCoverageDetailID = 1
            };
            endorsementList.Add(endorsement2);
            return endorsementList;*/
            return _endorsementManager.GetAll<ApiEndorsementModel>();
        }
    }
}