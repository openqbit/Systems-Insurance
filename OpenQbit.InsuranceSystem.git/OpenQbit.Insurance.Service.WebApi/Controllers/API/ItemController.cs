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
    public class ItemController : ApiController
    {
        IItemManager _itemManager = UnityResolver.Resolve<IItemManager>();
        public HttpResponseMessage Post(ApiItemModel item)
        {
            if (_itemManager.Record(item)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiItemModel item)
        {
            if (_itemManager.Update(item)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(ApiItemModel item)
        {
            if (_itemManager.Delete(item)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiItemModel Get(ApiItemModel item)
        {
            //    ApiItemModel item = new ApiItemModel
            //    {
            //        ID = (int)ID,
            //        Brand = "Honda",
            //        Name = "Civic",
            //        Value = 11500,
            //        PolicyCoverageDetailID = 001
            //    };

            //    return item;
            return _itemManager.Find<ApiItemModel>(e => e.ID == item.ID);
        }


        public List<ApiItemModel> GetList()
        {
            //List<ApiItemModel> itemList = new List<ApiItemModel>();
            //ApiItemModel item1 = new ApiItemModel
            //{
            //    ID = 1,
            //    Brand = "Honda",
            //    Name = "Civic",
            //    Value = 11500,
            //    PolicyCoverageDetailID = 001
            //};
            //itemList.Add(item1);
            //ApiItemModel item2 = new ApiItemModel
            //{
            //    ID = 2,
            //    Brand = "Toyota",
            //    Name = "Prious",
            //    Value = 15000,
            //    PolicyCoverageDetailID = 001
            //};
            //itemList.Add(item2);
            return _itemManager.GetAll<ApiItemModel>();
        }
    }
}