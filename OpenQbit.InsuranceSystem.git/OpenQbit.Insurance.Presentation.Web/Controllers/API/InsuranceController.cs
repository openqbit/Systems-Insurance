using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenQbit.Insurance.Presentation.Web.Models.API;
using OpenQbit.Insurance.Common.Models;

namespace OpenQbit.Insurance.Presentation.Web.Controllers
{
    public class InsuranceController : Controller
    {
        // GET: Insurance
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddInsurance(InsuranceAPIModel insurance,CoverageAPIModel coverage,DocumentAPIModel document,ItemAPIModel item,PolicyCoverageDetailAPIModel pcdm,PolicyTypeAPIModel policyType)
        {
            InsuranceModel Insurancemodel = new InsuranceModel
            {
                ID = insurance.ID,
                AgentID = insurance.AgentID,
                ClientID = insurance.ClientID,
                End_Date = insurance.End_Date,
                Joining_Date = insurance.Joining_Date,
                Total_Value = insurance.Total_Value,
            };

            DocumentModel DocumentModel = new DocumentModel
            {
                Document = document.Document,
                InsuranceID = document.InsuranceID,
                Authuorization = document.Authuorization,
                Insurance = new List<InsuranceModel>()
                {
                   Insurancemodel,

                }
            };

            PolicyCoverageDetailModel pcdModel = new PolicyCoverageDetailModel
            {
                ID = pcdm.ID,
                InsuranceID = Insurancemodel.ID,
                CoverageID = coverage.ID,
                CoverageValue = pcdm.CoverageValue,
                TotalPolicyValue = pcdm.TotalPolicyValue,
                Insurance = Insurancemodel,
                Coverage = new CoverageModel
                {
                    ID = coverage.ID,
                    Conditions = coverage.Conditions,
                    CoverageType = coverage.CoverageType,
                    Includes = coverage.Includes,
                    PolicyTypes = new PolicyTypeModel
                    {
                        ID = policyType.ID,
                        //policy type
                        Eligibilities = policyType.Eligibilities,
                    }
                }
            };
            ItemModel ItemModel = new ItemModel
            {
                ID = item.ID,
                Brand = item.Brand,
                Name = item.Name,
                PolicyCoverageDetail = pcdModel,
                PolicyCoverageDetailID = pcdModel.ID
            };


            return View();
        }
   }
}