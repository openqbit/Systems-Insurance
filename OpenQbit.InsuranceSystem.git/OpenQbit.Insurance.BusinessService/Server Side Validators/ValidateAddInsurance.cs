using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.BusinessService.Server_Side_Validators
{
    class ValidateAddInsurance
    {
        public bool ValidateForAge(int age)
        {
            if (age > 18)
            {
                return true;
            }
            return false;
        }
    }
}
