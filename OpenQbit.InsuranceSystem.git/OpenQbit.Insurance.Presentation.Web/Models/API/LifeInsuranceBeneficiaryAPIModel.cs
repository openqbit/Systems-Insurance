using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class LifeInsuranceBeneficiaryAPIModel
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