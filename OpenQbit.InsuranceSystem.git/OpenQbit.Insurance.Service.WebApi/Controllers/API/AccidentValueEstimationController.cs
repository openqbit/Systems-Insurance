using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;
using System.Collections;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class AccidentValueEstimationController : ApiController
    {
        public HttpResponseMessage Post(ApiAccidentValueEstimationModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(ApiAccidentValueEstimationModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public ApiAccidentValueEstimationModel Get(int? ID)
        {
            List<String> damagePartsList = new List<string>();
            damagePartsList.Add("Buffer");
            damagePartsList.Add("Fogg Light-Left");
            ApiAccidentValueEstimationModel accident = new ApiAccidentValueEstimationModel
            {
                ID = (int)ID,
                Reason = "Wet Weather",
                CostOfDamage = 20000,
                DamagedParts = new List<string>(damagePartsList),
                
            };
            return accident;

        }

        public List<ApiAccidentValueEstimationModel> GetList()
        {
            List<String> damagePartsList1 = new List<string>();
            damagePartsList1.Add("Buffer");
            damagePartsList1.Add("Fogg Light-Right");

            List<String> damagePartsList2 = new List<string>();
            damagePartsList2.Add("WindScreen");
            damagePartsList2.Add("Fogg Light-Right");

            List<ApiAccidentValueEstimationModel> accidentList = new List<ApiAccidentValueEstimationModel>();

            ApiAccidentValueEstimationModel accident1 = new ApiAccidentValueEstimationModel
            {

                ID = 1,
                Reason = "Wet Weather",
                CostOfDamage = 10000,
                DamagedParts = new List<string>(damagePartsList1),

            };
            accidentList.Add(accident1);

            ApiAccidentValueEstimationModel accident2 = new ApiAccidentValueEstimationModel
            {

                ID = 2,
                Reason = "Spare-Part Damages",
                CostOfDamage = 6000,
                DamagedParts = new List<string>(damagePartsList2),

            };
            accidentList.Add(accident2);
            return accidentList;
        }
    }
}
