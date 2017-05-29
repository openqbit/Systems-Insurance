using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OpenQbit.Insurance.Service.WebApi.Controllers
{
    public class AgentController : ApiController
    {
        //POST
        public HttpResponseMessage Post(ApiAgentModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(ApiAgentModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public ApiAgentModel Get(int? ID)
        {
            ApiAgentModel agent = new ApiAgentModel
            {
                ID = (int)ID,
                First_Name = "Pahansith",
                Last_Name = "Gunathilake",
                Age = 25,
                Address = "Matara",
                Date_of_Birth = new DateTime(1992,02,29),
                Email = "pahansith.wsg@gmail.com",
                Mobile = 0714303351,
                Telephone = 0415689512
            };

            return agent;
        }

        public List<ApiAgentModel> GetList()
        {
            List<ApiAgentModel> agentList = new List<ApiAgentModel>();
            ApiAgentModel agent1 = new ApiAgentModel
            {
                ID = 1,
                First_Name = "Pahansith",
                Last_Name = "Gunathilake",
                Age = 25,
                Address = "Matara",
                Date_of_Birth = new DateTime(1992, 02, 29),
                Email = "pahansith.wsg@gmail.com",
                Mobile = 0714303351,
                Telephone = 0415689512
            };
            agentList.Add(agent1);
            ApiAgentModel agent2 = new ApiAgentModel
            {
                ID = 2,
                First_Name = "Nuwani",
                Last_Name = "Kodagoda",
                Age = 23,
                Address = "Panadura",
                Date_of_Birth = new DateTime(1992, 02, 29),
                Email = "pahansith.wsg@gmail.com",
                Mobile = 0714303351,
                Telephone = 0415689512
            };
            agentList.Add(agent2);
            return agentList;
        }

    }
}
