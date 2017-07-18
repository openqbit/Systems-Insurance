using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Common.Ioc;
using OpenQbit.Insurance.BusinessService.Contracts;
using Microsoft.Practices.Unity;
using OpenQbit.Insurance.Common.Models;
using OpenQbit.Insurance.Service.WebApi.Models.API.Contracts;
using OpenQbit.Insurance.Service.WebApi.Mappers.APIMappers;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class InsuranceController : ApiController
    {
        IInsuranceManager _insuranceManager = UnityResolver.Resolve<IInsuranceManager>();

        [HttpPost]
        public HttpResponseMessage AddInsurance([FromBody]ApiInsuranceModel insurance)
        {
            //Mapping Api Models to Common Models
            APIModelMapper mapper = new APIModelMapper();

            InsuranceModel selectedInsurance = mapper.MapInsuranceTypeModel(insurance.InsuranceType,insurance,insurance.SelectedInsurance);
            ClientModel client = mapper.MapClientModel(insurance.Client);
            PolicyCoverageDetailModel policyCoverage =  mapper.MapPolicyCoverageDetailModel(insurance.PolicyDetails);
            DocumentModel document = mapper.MapDocumentModel(insurance.Documents);
            CoverageModel coverage = mapper.MapCoverage(insurance.Coverage);

            if (_insuranceManager.Record(selectedInsurance,client,policyCoverage,document,coverage)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiInsuranceModel insurance)
        {
            if (_insuranceManager.Update(insurance)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }

        public HttpResponseMessage Delete(ApiInsuranceModel insurance)
        {
            if (_insuranceManager.Delete(insurance)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiInsuranceModel Get(ApiInsuranceModel insurance)
        {
            /* ApiInsuranceModel insurance = new ApiInsuranceModel
             {
                 //ID = (int)ID,
                 //AgentID = 1,
                 //ClientID = 1,
                 //Joining_Date = new DateTime(2000, 02, 29),
                 //End_Date = new DateTime(2017, 02, 29),
                 //Total_Value = 1000000,
             };

             return insurance;*/

            return _insuranceManager.Find<ApiInsuranceModel>(e => e.ID == insurance.ID);
        }

        public List<ApiInsuranceModel> GetList()
        {
            /*List<ApiInsuranceModel> InsuranceList = new List<ApiInsuranceModel>();
            ApiInsuranceModel insurance1 = new ApiInsuranceModel
            {
                //ID = 1,
                //AgentID = 1,
                //ClientID = 1,
                //Joining_Date = new DateTime(2000, 02, 29),
                //End_Date = new DateTime(2017, 02, 29),
                //Total_Value = 1000000,
            };
            InsuranceList.Add(insurance1);
            ApiInsuranceModel insurance2 = new ApiInsuranceModel
            {
                //ID = 2,
                //AgentID = 1,
                //ClientID = 1,
                //Joining_Date = new DateTime(2010, 02, 29),
                //End_Date = new DateTime(2020, 02, 29),
                //Total_Value = 1000000,
            };
            InsuranceList.Add(insurance2);
            return InsuranceList;*/

            return _insuranceManager.GetAll<ApiInsuranceModel>();
        }
    }
}