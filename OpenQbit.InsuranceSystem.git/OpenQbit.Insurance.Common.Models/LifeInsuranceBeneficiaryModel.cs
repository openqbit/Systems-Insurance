using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    public class LifeInsuranceBeneficiaryModel : BeneficiaryModel
    {
        public enum RelationshipTypes
        {
            Father, Mother, Cousin, Spouce, GrandMother, GrandFather
        }

        public RelationshipTypes RelationshipForTheClient { get; set; }
        
    }
}
