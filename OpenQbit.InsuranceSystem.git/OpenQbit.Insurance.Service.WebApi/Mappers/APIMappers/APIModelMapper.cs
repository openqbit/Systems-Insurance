using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Mappers.APIMappers
{
    public class APIModelMapper
    {
        public WebApi.Models.API.ApiClientModel MapAPIClientModel(Common.Models.ClientModel client)
        {

            return new WebApi.Models.API.ApiClientModel { First_Name = client.First_Name, Last_Name = client.Last_Name };
        }

    }
}