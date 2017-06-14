using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Common.Ioc;
using OpenQbit.Insurance.BusinessService.Contracts;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class PolicyCoverageDetailController : ApiController
    {
        IPolicyCoverageDetailManager _policyManager = UnityResolver.Resolve<IPolicyCoverageDetailManager>();
        public HttpResponseMessage Post(ApiPolicyCoverageDetailModel accident)
        {
            if (_policyManager.Recored(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiPolicyCoverageDetailModel accident)
        {
            if (_policyManager.Update(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }

        public HttpResponseMessage Delete(ApiPolicyCoverageDetailModel accident)
        {
            if (_policyManager.Delete(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiPolicyCoverageDetailModel Get(ApiPolicyCoverageDetailModel accident)
        {
            /* ApiPolicyCoverageDetailModel pcdm = new ApiPolicyCoverageDetailModel
             {
                 ID = (int)ID,
                 CoverageValue = 10000,
                 TotalPolicyValue = 100000,
                 Note = "Please Note That",
                 InsuranceID = 1,
                 CoverageID =1,
             };

             return pcdm;*/
            return _policyManager.Find<ApiPolicyCoverageDetailModel>(e => e.ID == accident.ID);
        }

        public List<ApiPolicyCoverageDetailModel> GetList()
        {
            /* List<ApiPolicyCoverageDetailModel> pcdmList = new List<ApiPolicyCoverageDetailModel>();
             ApiPolicyCoverageDetailModel pcdm1 = new ApiPolicyCoverageDetailModel
             {
                 ID = 1,
                 CoverageValue = 10000,
                 TotalPolicyValue = 100000,
                 Note = "Please Note That",
                 InsuranceID = 1,
                 CoverageID = 1,
             };
             pcdmList.Add(pcdm1);
             ApiPolicyCoverageDetailModel pcdm2 = new ApiPolicyCoverageDetailModel
             {
                 ID = 2,
                 CoverageValue = 10000,
                 TotalPolicyValue = 100000,
                 Note = "Please Note That",
                 InsuranceID = 2,
                 CoverageID = 2,
             };
             pcdmList.Add(pcdm2);
             return pcdmList;*/
            return _policyManager.GetAll<ApiPolicyCoverageDetailModel>();
        }
    }
}