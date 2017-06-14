using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class PolicyCoverageDetailController : ApiController
    {
        public HttpResponseMessage Post(ApiPolicyCoverageDetailModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(ApiPolicyCoverageDetailModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public ApiPolicyCoverageDetailModel Get(int? ID)
        {
            ApiPolicyCoverageDetailModel pcdm = new ApiPolicyCoverageDetailModel
            {
                ID = (int)ID,
                CoverageValue = 10000,
                TotalPolicyValue = 100000,
                Note = "Please Note That",
                InsuranceID = 1,
                CoverageID =1,
            };

            return pcdm;
        }

        public List<ApiPolicyCoverageDetailModel> GetList()
        {
            List<ApiPolicyCoverageDetailModel> pcdmList = new List<ApiPolicyCoverageDetailModel>();
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
            return pcdmList;
        }
    }
}