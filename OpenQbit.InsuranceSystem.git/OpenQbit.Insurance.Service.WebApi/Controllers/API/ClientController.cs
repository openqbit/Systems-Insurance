using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using OpenQbit.Insurance.BusinessService.Contracts;
using OpenQbit.Insurance.Common.Ioc;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class ClientController : ApiController
    {
        IClientManager _clientManager = UnityResolver.Resolve<IClientManager>();

        public HttpResponseMessage Post(ApiClientModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(ApiClientModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public ApiClientModel Get(int? ID)
        {
            //ApiClientModel client = new ApiClientModel
            //{
                //ID = (int)ID,
                //First_Name = "Pahansith",
                //Middle_Name = "Wijesinghe",
                //Last_Name = "Gunathilake",
                //Age = 25,
                //BloodGroup = ApiClientModel.BloodGroups.O_pos,
                //Gender = ApiClientModel.Genders.MALE,
                //Nationality = "Sinhala",
                //Religion = "Buddhism",
                //Address = "Matara",
                //Date_of_Birth = new DateTime(1992, 02, 29),
                //Email = "pahansith.wsg@gmail.com",
                //Mobile = 0714303351,
                //Telephone = 0415689512
            //};

            // return client;
            return _clientManager.Find<ApiClientModel>(e => e.ID == ID);
        }

        public List<ApiClientModel> GetList()
        {
            //List<ApiClientModel> clientList = new List<ApiClientModel>();
            //ApiClientModel client1 = new ApiClientModel
            //{
                //ID = 1,
                //First_Name = "Pahansith",
                //Middle_Name = "Wijesinghe",
                //Last_Name = "Gunathilake",
                //Age = 25,
                //BloodGroup = ApiClientModel.BloodGroups.O_pos,
                //Gender = ApiClientModel.Genders.MALE,
                //Nationality = "Sinhala",
                //Religion = "Buddhism",
                //Address = "Matara",
                //Date_of_Birth = new DateTime(1992, 02, 29),
                //Email = "pahansith.wsg@gmail.com",
                //Mobile = 0714303351,
                //Telephone = 0415689512
            //};
            //clientList.Add(client1);
            //ApiClientModel client2 = new ApiClientModel
            //{
                //ID = 2,
                //First_Name = "Nuwani",
                //Middle_Name = "Theekshana",
                //Last_Name = "Kodagoda",
                //Age = 23,
                //BloodGroup = ApiClientModel.BloodGroups.O_pos,
                //Gender = ApiClientModel.Genders.FEMALE,
                //Nationality = "Sinhala",
                //Religion = "Buddhism",
                //Address = "Panadura",
                //Date_of_Birth = new DateTime(1992, 02, 29),
                //Email = "pahansith.wsg@gmail.com",
                //Mobile = 0714303351,
                //Telephone = 0415689512
           // };
            //clientList.Add(client2);
            //return clientList;

            return _clientManager.GetAll<ApiClientModel>();
        }
    }
}
