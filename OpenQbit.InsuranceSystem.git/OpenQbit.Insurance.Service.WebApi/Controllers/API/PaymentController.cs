using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class PaymentController : ApiController
    {
        public HttpResponseMessage Post(ApiPaymentModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(ApiPaymentModel accident)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public ApiPaymentModel Get(int? ID)
        {
            ApiPaymentModel payment = new ApiPaymentModel
            {
                ID = (int)ID,
                Amount = 5000,
                Date_and_time = new DateTime(2017,05,15)
            };

            return payment;
        }

        public List<ApiPaymentModel> GetList()
        {
            List<ApiPaymentModel> paymentList = new List<ApiPaymentModel>();
            ApiPaymentModel payment1 = new ApiPaymentModel
            {
                ID = 1,
                Amount = 5000,
                Date_and_time = new DateTime (2017, 05, 25)
            };
            paymentList.Add(payment1);

            ApiPaymentModel payment2 = new ApiPaymentModel
            {
                ID = 2,
                Amount = 2000,
                Date_and_time = new DateTime(2017, 05, 28)
            };
            paymentList.Add(payment2);
            return paymentList;
        }
    }
}