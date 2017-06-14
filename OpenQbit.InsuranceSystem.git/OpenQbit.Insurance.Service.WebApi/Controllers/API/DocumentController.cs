using OpenQbit.Insurance.Service.WebApi.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Common.Ioc;
using OpenQbit.Insurance.BusinessService.Contracts;
using Microsoft.Practices.Unity; // InjectionConstructor

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class DocumentController : ApiController
    {
        IDocumentManager _documentManager = UnityResolver.Resolve<IDocumentManager>();

        public HttpResponseMessage Post(ApiDocumentModel document)
        {
            if (_documentManager.Recored(document)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiDocumentModel document)
        {
            if (_documentManager.Update(document)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(ApiDocumentModel document)
        {
            if(_documentManager.Delete(document)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiDocumentModel Get(int? ID)
        {
        //    ApiDocumentModel document = new ApiDocumentModel {
        //        ID = (int)ID,
        //        Document = new byte[100],
        //        Authuorization = true,
        //        InsuranceID = 1002
        //    };
        //    return document;

            return _documentManager.Find<ApiDocumentModel>(e => e.ID == agent.ID);
        }

        public List<ApiDocumentModel> GetAll() {
            //List<ApiDocumentModel> docList = new List<ApiDocumentModel>
            //{
            //    new ApiDocumentModel
            //    {
            //        ID = 1,
            //        Document = new byte[100],
            //        Authuorization = true,
            //        InsuranceID = 1002
            //    },
            //    new ApiDocumentModel
            //    {
            //        ID = 2,
            //        Document = new byte[100],
            //        Authuorization = true,
            //        InsuranceID = 1002
            //    },
            //};
            //return docList;

            return _documentManager.GetAll<ApiDocumentModel>();
        }
    }
}
