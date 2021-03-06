﻿using OpenQbit.Insurance.Service.WebApi.Models.API;
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

        public ApiInsuranceModel Get(String insuranceId)
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

            InsuranceModel selectedInsurance = _insuranceManager.Find<InsuranceModel>(e => e.ID.Equals(insuranceId));
            ClientModel clientModel = _insuranceManager.Find<ClientModel>(e => e.ID.Equals(selectedInsurance.ID));
            DocumentModel document = _insuranceManager.Find<DocumentModel>(e => e.InsuranceID.Equals(selectedInsurance.ID));
            PolicyCoverageDetailModel pcd =  _insuranceManager.Find<PolicyCoverageDetailModel>(e => e.InsuranceID.Equals(selectedInsurance.ID));
            CoverageModel coverage =_insuranceManager.Find<CoverageModel>(e => e.ID.Equals(pcd.CoverageID));

            CommonToApiModelMapper mapper = new CommonToApiModelMapper();
            ApiInsuranceModel mapped = new ApiInsuranceModel();
            if (selectedInsurance.InsuranceType.Equals(InsuranceModel.InsuranceTypes.LIFE_INSURANCE))
            {
                LifeInsuranceModel life =  _insuranceManager.Find<LifeInsuranceModel>(e => e.ClientID.Equals(selectedInsurance.ClientID));
                ApiLifeInsuranceModel apiLifeInsuranceModel = mapper.MapLifeInsuranceCommonModel(life);
                mapped.SelectedInsurance = apiLifeInsuranceModel;
            }
            ApiClientModel apiCLient = mapper.MapClientCommonModel(clientModel);
            ApiDocumentModel apiDoc = mapper.MapDocumentCommonModel(document);
            ApiPolicyCoverageDetailModel apiPcd = mapper.MapPolicyCoverageDetailCommonModel(pcd);
            ApiCoverageModel apiCoverage = mapper.MapCoverageCommonModel(coverage);

            mapped.Client = apiCLient;
            mapped.Coverage = apiCoverage;
            mapped.Documents = apiDoc;
            mapped.PolicyDetails = apiPcd;

            return mapped;

            
        }

        public List<ApiInsuranceModel> GetList()
        {
            return null;
        }
    }
}