using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.BusinessService.Contracts;
using Microsoft.Practices.Unity; // InjectionConstructor

namespace OpenQbit.Insurance.Service.WebApi.Controllers
{
    public class AgentController : ApiController
    {
        IAgentManager _agentManager;

        [InjectionConstructor]
        public AgentController(IAgentManager agentManager)
        {
            _agentManager = agentManager;
        }

        public HttpResponseMessage Post(ApiAgentModel agent)
        {
            if (_agentManager.Recored(agent)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);  
        }

        public HttpResponseMessage Put(ApiAgentModel agent)
        {
            if (_agentManager.Update(agent)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }

        public HttpResponseMessage Delete(ApiAgentModel agent)
        {
            if (_agentManager.Delete(agent)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiAgentModel Get(ApiAgentModel agent)
        {
            /*ApiAgentModel agent = new ApiAgentModel
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

            return agent;*/
           return _agentManager.Find<ApiAgentModel>(e => e.ID == agent.ID);
        }

        public List<ApiAgentModel> GetList()
        {
            /*List<ApiAgentModel> agentList = new List<ApiAgentModel>();
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
            return agentList;*/
            return _agentManager.GetAll<ApiAgentModel>();
        }

    }
}
