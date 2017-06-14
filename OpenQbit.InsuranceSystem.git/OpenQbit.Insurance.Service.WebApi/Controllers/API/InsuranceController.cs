using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class InsuranceController : ApiController
    {
        public HttpResponseMessage Post(ApiInsuranceModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(ApiInsuranceModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public ApiInsuranceModel Get(int? ID)
        {
            ApiInsuranceModel insurance = new ApiInsuranceModel
            {
                ID = (int)ID,
                AgentID = 1,
                ClientID = 1,
                Joining_Date = new DateTime(2000, 02, 29),
                End_Date = new DateTime(2017, 02, 29),
                Total_Value = 1000000,
            };

            return insurance;
        }

        public List<ApiInsuranceModel> GetList()
        {
            List<ApiInsuranceModel> InsuranceList = new List<ApiInsuranceModel>();
            ApiInsuranceModel insurance1 = new ApiInsuranceModel
            {
                ID = 1,
                AgentID = 1,
                ClientID = 1,
                Joining_Date = new DateTime(2000, 02, 29),
                End_Date = new DateTime(2017, 02, 29),
                Total_Value = 1000000,
            };
            InsuranceList.Add(insurance1);
            ApiInsuranceModel insurance2 = new ApiInsuranceModel
            {
                ID = 2,
                AgentID = 1,
                ClientID = 1,
                Joining_Date = new DateTime(2010, 02, 29),
                End_Date = new DateTime(2020, 02, 29),
                Total_Value = 1000000,
            };
            InsuranceList.Add(insurance2);
            return InsuranceList;
        }
    }
}