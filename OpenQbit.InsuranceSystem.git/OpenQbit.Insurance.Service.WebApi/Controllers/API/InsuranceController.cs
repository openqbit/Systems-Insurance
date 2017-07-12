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
    public class InsuranceController : ApiController
    {
        IInsuranceManager _insuranceManager = UnityResolver.Resolve<IInsuranceManager>();

        public HttpResponseMessage Post(ApiInsuranceModel insurance)
        {
            if (_insuranceManager.Record(insurance)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiInsuranceModel insurance)
        {
            if (_insuranceManager.Update(insurance)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }

        public HttpResponseMessage Delete(ApiInsuranceModel insurance)
        {
            if (_insuranceManager.Delete(insurance)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiInsuranceModel Get(ApiInsuranceModel insurance)
        {
            /* ApiInsuranceModel insurance = new ApiInsuranceModel
             {
                 //ID = (int)ID,
                 //AgentID = 1,
                 //ClientID = 1,
                 //Joining_Date = new DateTime(2000, 02, 29),
                 //End_Date = new DateTime(2017, 02, 29),
                 //Total_Value = 1000000,
             };

             return insurance;*/

            return _insuranceManager.Find<ApiInsuranceModel>(e => e.ID == insurance.ID);
        }

        public List<ApiInsuranceModel> GetList()
        {
            /*List<ApiInsuranceModel> InsuranceList = new List<ApiInsuranceModel>();
            ApiInsuranceModel insurance1 = new ApiInsuranceModel
            {
                //ID = 1,
                //AgentID = 1,
                //ClientID = 1,
                //Joining_Date = new DateTime(2000, 02, 29),
                //End_Date = new DateTime(2017, 02, 29),
                //Total_Value = 1000000,
            };
            InsuranceList.Add(insurance1);
            ApiInsuranceModel insurance2 = new ApiInsuranceModel
            {
                //ID = 2,
                //AgentID = 1,
                //ClientID = 1,
                //Joining_Date = new DateTime(2010, 02, 29),
                //End_Date = new DateTime(2020, 02, 29),
                //Total_Value = 1000000,
            };
            InsuranceList.Add(insurance2);
            return InsuranceList;*/

            return _insuranceManager.GetAll<ApiInsuranceModel>();
        }
    }
}