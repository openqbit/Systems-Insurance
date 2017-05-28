using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class CoverageController : ApiController
    {
        public bool Add(ApiCoverageModel coverage)
        {
            return true;
        }

        public bool Update(ApiCoverageMode coverage)
        {
            return true;
        }

        public ApiCoverageModel Get(int? ID)
        {
            ApiCoverageModel coverage = new ApiCoverageModel
            {
                ID = (int)ID,
                CoverageType = "Fire Coverage",
                Includes = "Car,Furnitures,Grand Piano",
                Conditions= "Fire insurance covers a policyholder against fire loss or damage brought about by the ignition of fire, electricity, lightning or explosion of gas, natural disasters, and bursting and overflowing of a water tank or pipes.",
            };
            return coverage;
        }

        public List<ApiCoverageModel> Get()
        {
            List<ApiCoverageModel> CoverageList = new List<ApiCoverageModel>();

            ApiCoverageModel coverage1 = new ApiCoverageModel
            {
                ID = (int)ID,
                CoverageType = "Fire Coverage",
                Includes = "Car,Furnitures,Grand Piano",
                Conditions = "Fire insurance covers a policyholder against fire loss or damage brought about by the ignition of fire, electricity, lightning or explosion of gas, natural disasters, and bursting and overflowing of a water tank or pipes.",
            };
            CoverageList.Add(coverage1);

            ApiCoverageModel coverage2 = new ApiCoverageModel
            {
                ID = (int)ID,
                CoverageType = "Fire Coverage",
                Includes = "Car,Furnitures,House",
                Conditions = "Fire insurance covers a policyholder against fire loss or damage brought about by the ignition of fire, electricity, lightning or explosion of gas, natural disasters, and bursting and overflowing of a water tank or pipes.",
            };
            CoverageList.Add(coverage2);
        }


    }
}