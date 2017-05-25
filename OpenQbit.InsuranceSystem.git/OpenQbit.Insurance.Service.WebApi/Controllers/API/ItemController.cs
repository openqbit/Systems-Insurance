using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Insurance.Service.WebApi.Models.API;

namespace OpenQbit.Insurance.Service.WebApi.Controllers.API
{
    public class ItemController : ApiController
    {
        public bool Add(ApiItemModel item)
        {
            return true;
        }

        public bool Update(ApiItemModel item)
        {
            return true;
        }

        public ApiItemModel Get(int? ID)
        {
            ApiItemModel item = new ApiItemModel
            {
                ID = (int)ID,
                Brand = "Honda",
                Name = "Civic",
                Value = 11500,
                PolicyCoverageDetailID = 001
            };

            return item;
        }

        public List<ApiItemModel> GetList()
        {
            List<ApiItemModel> itemList = new List<ApiItemModel>();
            ApiItemModel item1 = new ApiItemModel
            {
                ID = 1,
                Brand = "Honda",
                Name = "Civic",
                Value = 11500,
                PolicyCoverageDetailID = 001
            };
            itemList.Add(item1);
            ApiItemModel item2 = new ApiItemModel
            {
                ID = 2,
                Brand = "Toyota",
                Name = "Prious",
                Value = 15000,
                PolicyCoverageDetailID = 001
            };
            itemList.Add(item2);
            return itemList;
        }
    }
}