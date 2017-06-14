using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using OpenQbit.Insurance.Common.Ioc;
using OpenQbit.Insurance.BusinessService.Contracts;
using Microsoft.Practices.Unity; // InjectionConstructor

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class CoverageController : ApiController
    {
        ICoverageManager _coverageManager = UnityResolver.Resolve<ICoverageManager>();

        public HttpResponseMessage Post(ApiCoverageModel accident)
        {
            if (_coverageManager.Recored(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiCoverageModel accident)
        {
            if (_coverageManager.Update(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(ApiCoverageModel accident)
        {
            if (_coverageManager.Delete(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiCoverageModel Get(int? ID)
        {
            //ApiCoverageModel coverage = new ApiCoverageModel
            //{
            //    ID = (int)ID,
            //    CoverageType = "Fire Coverage",
            //    Includes = "Car,Furnitures,Grand Piano",
            //    conditions= "Fire insurance covers a policyholder against fire loss or damage brought about by the ignition of fire, electricity, lightning or explosion of gas, natural disasters, and bursting and overflowing of a water tank or pipes.",
            //};
            //return coverage;

            return _coverageManager.Find<ApiCoverageModel>(e => e.ID == agent.ID);
        }

        public List<ApiCoverageModel> GetList()
        {
            //List<ApiCoverageModel> CoverageList = new List<ApiCoverageModel>();

            //ApiCoverageModel coverage1 = new ApiCoverageModel
            //{
            //    ID = 1,
            //    CoverageType = "Fire Coverage",
            //    Includes = "Car,Furnitures,Grand Piano",
            //    conditions = "Fire insurance covers a policyholder against fire loss or damage brought about by the ignition of fire, electricity, lightning or explosion of gas, natural disasters, and bursting and overflowing of a water tank or pipes.",
            //};
            //CoverageList.Add(coverage1);

                //ApiCoverageModel coverage2 = new ApiCoverageModel
                //{
                //    ID = 2,
                //    CoverageType = "Fire Coverage",
                //    Includes = "Car,Furnitures,House",
                //    conditions = "Fire insurance covers a policyholder against fire loss or damage brought about by the ignition of fire, electricity, lightning or explosion of gas, natural disasters, and bursting and overflowing of a water tank or pipes.",
                //};
                //CoverageList.Add(coverage2);

                //return CoverageList;

            return _coverageManager.GetAll<ApiCoverageModel>();
        }


    }
}