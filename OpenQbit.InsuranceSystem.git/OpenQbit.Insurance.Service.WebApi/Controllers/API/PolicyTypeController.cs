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
    public class PolicyTypeController : ApiController
    {
        IPolicyTypeManager _policyTypeManager = UnityResolver.Resolve<IPolicyTypeManager>();

        public HttpResponseMessage Post(ApiPolicyTypeModel accident)
        {
            if (_policyTypeManager.Recored(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiPolicyTypeModel accident)
        {

            if (_policyTypeManager.Update(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(ApiPolicyTypeModel accident)
        {
            if (_policyTypeManager.Delete(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiPolicyTypeModel Get(ApiPolicyTypeModel accident)
        {
            List<String> eligibilities = new List<string>();
            eligibilities.Add("18+");
            eligibilities.Add("Nationality - SriLankan");

            /*ApiPolicyTypeModel policyType = new ApiPolicyTypeModel
            {
                ID = (int)ID,
                Type = PolicyTypes.Life,
                Eligibilities = eligibilities
            };

            return policyType;*/
            return _policyTypeManager.Find<ApiPolicyTypeModel>(e => e.ID == accident.ID);
        }

        public List<ApiPolicyTypeModel> GetList()
        {
            List<ApiPolicyTypeModel> policyTypeList = new List<ApiPolicyTypeModel>();
            List<String> eligibilities1 = new List<string>();
            eligibilities1.Add("18+");
            eligibilities1.Add("Nationality - SriLankan");

            /*ApiPolicyTypeModel policyType1 = new ApiPolicyTypeModel
            {
                ID = 1,
                Type = PolicyTypes.Life,
                Eligibilities = eligibilities1
            };
            ApiPolicyTypeModel policyType2 = new ApiPolicyTypeModel
            {
                ID = 2,
                Type = PolicyTypes.Marine,
                Eligibilities = eligibilities1
            };
            policyTypeList.Add(policyType1);
            policyTypeList.Add(policyType2);

            return policyTypeList;*/
            return _policyTypeManager.GetAll<ApiPolicyTypeModel>();
        }
    }
        
}
