using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;
using System.Collections;
using OpenQbit.Insurance.Common.Ioc;
using OpenQbit.Insurance.BusinessService.Contracts;
namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class AccidentValueEstimationController : ApiController
    {

        IAccidentValueEstimationManager _accidentValueEstimationManager = UnityResolver.Resolve<IAccidentValueEstimationManager>();

        public HttpResponseMessage Post(ApiAccidentValueEstimationModel accident)
        {
            if (_accidentValueEstimationManager.Recored(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiAccidentValueEstimationModel accident)
        {
            if (_accidentValueEstimationManager.Update(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(ApiAccidentValueEstimationModel accident)
        {
            if (_accidentValueEstimationManager.Delete(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiAccidentValueEstimationModel Get(ApiAccidentValueEstimationModel accidentValueEstimation)
        {
            //List<String> damagePartsList = new List<string>();
            //damagePartsList.Add("Buffer");
            //damagePartsList.Add("Fogg Light-Left");
            //ApiAccidentValueEstimationModel accident = new ApiAccidentValueEstimationModel
            //{
            //    ID = (int)ID,
            //    Reason = "Wet Weather",
            //    CostOfDamage = 20000,
            //    DamagedParts = new List<string>(damagePartsList),

            //};
            //return accident;
            return _accidentValueEstimationManager.Find<ApiAccidentValueEstimationModel>(e => e.ID == accidentValueEstimation.ID);
        }

        public List<ApiAccidentValueEstimationModel> GetList()
        {
            //List<String> damagePartsList1 = new List<string>();
            //damagePartsList1.Add("Buffer");
            //damagePartsList1.Add("Fogg Light-Right");

            //List<String> damagePartsList2 = new List<string>();
            //damagePartsList2.Add("WindScreen");
            //damagePartsList2.Add("Fogg Light-Right");

            //List<ApiAccidentValueEstimationModel> accidentList = new List<ApiAccidentValueEstimationModel>();

            //ApiAccidentValueEstimationModel accident1 = new ApiAccidentValueEstimationModel
            //{

            //    ID = 1,
            //    Reason = "Wet Weather",
            //    CostOfDamage = 10000,
            //    DamagedParts = new List<string>(damagePartsList1),

            //};
            //accidentList.Add(accident1);

            //ApiAccidentValueEstimationModel accident2 = new ApiAccidentValueEstimationModel
            //{

            //    ID = 2,
            //    Reason = "Spare-Part Damages",
            //    CostOfDamage = 6000,
            //    DamagedParts = new List<string>(damagePartsList2),

            //};
            //accidentList.Add(accident2);
            //return accidentList;
            return _accidentValueEstimationManager.GetAll<ApiAccidentValueEstimationModel>();
        }
    }
}
