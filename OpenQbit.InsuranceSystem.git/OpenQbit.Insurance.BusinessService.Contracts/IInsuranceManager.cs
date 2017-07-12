using OpenQbit.Insurance.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.BusinessService.Contracts
{
    public interface IInsuranceManager : ICommonServiceManager
    {
        
        bool Record(InsuranceModel insurance,ClientModel client);
    }
}
