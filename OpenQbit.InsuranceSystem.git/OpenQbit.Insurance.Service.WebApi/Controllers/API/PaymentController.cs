using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;
using OpenQbit.Insurance.Common.Ioc;
using OpenQbit.Insurance.BusinessService.Contracts;
using Microsoft.Practices.Unity; // InjectionConstructor

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class PaymentController : ApiController
    {
        IPaymentManager _paymentManager = UnityResolver.Resolve<IPaymentManager>();
        public HttpResponseMessage Post(ApiPaymentModel payment)
        {
            if (_paymentManager.Recored(payment)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiPaymentModel payment)
        {
            if (_agentManager.Update(payment)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(ApiPaymentModel payment)
        {
            if (_agentManager.Delete(payment)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiPaymentModel Get(ApiPaymentModel payment)
        {
            //ApiPaymentModel payment = new ApiPaymentModel
            //{
            //    ID = (int)ID,
            //    Amount = 5000,
            //    Date_and_time = new DateTime(2017,05,15)
            //};

            return _paymentManager.Find<ApiPaymentModel>(e => e.ID == payment.ID);
        }

        public List<ApiPaymentModel> GetList()
        {
            //List<ApiPaymentModel> paymentList = new List<ApiPaymentModel>();
            //ApiPaymentModel payment1 = new ApiPaymentModel
            //{
            //    ID = 1,
            //    Amount = 5000,
            //    Date_and_time = new DateTime (2017, 05, 25)
            //};
            //paymentList.Add(payment1);

            //ApiPaymentModel payment2 = new ApiPaymentModel
            //{
            //    ID = 2,
            //    Amount = 2000,
            //    Date_and_time = new DateTime(2017, 05, 28)
            //};
            //paymentList.Add(payment2);
            return _paymentManager.GetAll<ApiPaymentModel>();
        }
    }
}