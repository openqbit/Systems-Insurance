using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi;

using OpenQbit.Insurance.Service.WebApi.Models.API;

    public class DocumentController : ApiController
    {
        public bool Add(ApiDocumentModel document)
        {
            return true;
        }

        public bool Update(ApiDocumentModel document)
        {
            return true;
        }

        public ApiDocumentModel Get(int? ID)
        {
        ApiDocumentModel document = new ApiDocumentModel
            {
                
                ID = (int)ID,
                InsuranceID = 123,
                Authuerisation = "This is authorisation",
                Copy = 25,
                
            };

            return document;
        }

        public List<ApiDocumentModel> GetList()
        {
            List<ApiDocumentModel> documentList = new List<ApiDocumentModel>();
        ApiDocumentModel document1 = new ApiDocumentModel
        {
            ID = 1,
            InsuranceID = 123,
            Authuerisation = "This is authorisation",
            Copy = 25,

        };
        documentList.Add(document1);
        ApiDocumentModel document2 = new ApiDocumentModel
        {
            ID = 2,
            InsuranceID = 1234,
            Authuerisation = "This is authorisation",
            Copy = 25,
        };
        documentList.Add(document2);
            return documentList;
        }
    }
