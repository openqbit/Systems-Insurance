using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models.API
{
    public class ApiLifeInsuranceBeneficiaryModel
    {
        public enum RelationshipTypes
        {
            Father, Mother, Cousin, Spouce, GrandMother, GrandFather
        }

        public RelationshipTypes RelationshipForTheClient { get; set; }
    }
}