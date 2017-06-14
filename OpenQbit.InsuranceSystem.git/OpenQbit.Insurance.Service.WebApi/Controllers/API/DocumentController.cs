using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class DocumentController : ApiController
    {
        public HttpResponseMessage Post(ApiDocumentModel document)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(ApiDocumentModel document)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public ApiDocumentModel Get(int? ID)
        {
            ApiDocumentModel document = new ApiDocumentModel {
                ID = (int)ID,
                Document = new byte[100],
                Authuorization = true,
                InsuranceID = 1002
            };
            return document;
        }

        public List<ApiDocumentModel> GetAll() {
            List<ApiDocumentModel> docList = new List<ApiDocumentModel>
            {
                new ApiDocumentModel
                {
                    ID = 1,
                    Document = new byte[100],
                    Authuorization = true,
                    InsuranceID = 1002
                },
                new ApiDocumentModel
                {
                    ID = 2,
                    Document = new byte[100],
                    Authuorization = true,
                    InsuranceID = 1002
                },
            };
            return docList;
        }
    }
}
