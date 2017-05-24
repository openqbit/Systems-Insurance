using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class ClientController : ApiController
    {
        public bool Add(ApiClientModel client)
        {
            return true;
        }

        public bool Update(ApiClientModel client)
        {
            return true;
        }

        public ApiClientModel Get(int? ID)
        {
            ApiClientModel client = new ApiClientModel
            {
                ID = (int)ID,
                First_Name = "Pahansith",
                Middle_Name = "Wijesinghe",
                Last_Name = "Gunathilake",
                Age = 25,
                BloodGroup = ApiClientModel.BloodGroups.O_pos,
                Gender = ApiClientModel.Genders.MALE,
                Nationality = "Sinhala",
                Religion = "Buddhism",
                Address = "Matara",
                Date_of_Birth = new DateTime(1992, 02, 29),
                Email = "pahansith.wsg@gmail.com",
                Mobile = 0714303351,
                Telephone = 0415689512
            };

            return client;
        }

        public List<ApiClientModel> GetList()
        {
            List<ApiClientModel> clientList = new List<ApiClientModel>();
            ApiClientModel client1 = new ApiClientModel
            {
                ID = 1,
                First_Name = "Pahansith",
                Middle_Name = "Wijesinghe",
                Last_Name = "Gunathilake",
                Age = 25,
                BloodGroup = ApiClientModel.BloodGroups.O_pos,
                Gender = ApiClientModel.Genders.MALE,
                Nationality = "Sinhala",
                Religion = "Buddhism",
                Address = "Matara",
                Date_of_Birth = new DateTime(1992, 02, 29),
                Email = "pahansith.wsg@gmail.com",
                Mobile = 0714303351,
                Telephone = 0415689512
            };
            clientList.Add(client1);
            ApiClientModel client2 = new ApiClientModel
            {
                ID = 2,
                First_Name = "Nuwani",
                Middle_Name = "Theekshana",
                Last_Name = "Kodagoda",
                Age = 23,
                BloodGroup = ApiClientModel.BloodGroups.O_pos,
                Gender = ApiClientModel.Genders.FEMALE,
                Nationality = "Sinhala",
                Religion = "Buddhism",
                Address = "Panadura",
                Date_of_Birth = new DateTime(1992, 02, 29),
                Email = "pahansith.wsg@gmail.com",
                Mobile = 0714303351,
                Telephone = 0415689512
            };
            clientList.Add(client2);
            return clientList;
        }
    }
}
