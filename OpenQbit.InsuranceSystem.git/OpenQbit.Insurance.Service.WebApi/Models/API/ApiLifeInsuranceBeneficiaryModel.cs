using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models.API
{
    public class ApiLifeInsuranceBeneficiaryModel
    {
        public String BeneficiaryName { get; set; }
        public DateTime Dob { get; set; }
        public string NIC { get; set; }
        public enum RelationshipTypes
        {
            Father, Mother, Cousin, Spouce, GrandMother, GrandFather
        }

        public RelationshipTypes RelationshipForTheClient { get; set; }
    }
}