﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class EndorsementController : ApiController
    {
        public HttpResponseMessage Post(ApiEndorsementModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(ApiEndorsementModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public ApiEndorsementModel Get(int? ID)
        {
            ApiEndorsementModel endorsement = new ApiEndorsementModel
            {
                ID = (int)ID,
                Details = "Nothing",
                PolicyCoverageDetailID = 1
            };

            return endorsement;
        }

        public List<ApiEndorsementModel> GetList()
        {
            List<ApiEndorsementModel> endorsementList = new List<ApiEndorsementModel>();
            ApiEndorsementModel endorsement1 = new ApiEndorsementModel
            {
                ID = 1,
                Details = "Nothing",
                PolicyCoverageDetailID = 1
            };
            endorsementList.Add(endorsement1);

            ApiEndorsementModel endorsement2 = new ApiEndorsementModel
            {
                ID = 2,
                Details = "Nothing",
                PolicyCoverageDetailID = 1
            };
            endorsementList.Add(endorsement2);
            return endorsementList;
        }
    }
}