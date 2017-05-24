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
        public bool Add(ApiInsurance insurance)
        {
            return true;
        }

        public bool Update(ApiInsurance insurance)
        {
            return true;
        }

        public ApiInsurance Get(int? ID)
        {
            ApiInsurance insurance = new ApiInsurance
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

        public List<ApiInsurance> GetList()
        {
            List<ApiInsurance> InsuranceList = new List<ApiInsurance>();
            ApiInsurance insurance1 = new ApiInsurance
            {
                ID = 1,
                AgentID = 1,
                ClientID = 1,
                Joining_Date = new DateTime(2000, 02, 29),
                End_Date = new DateTime(2017, 02, 29),
                Total_Value = 1000000,
            };
            InsuranceList.Add(insurance1);
            ApiInsurance insurance2 = new ApiInsurance
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