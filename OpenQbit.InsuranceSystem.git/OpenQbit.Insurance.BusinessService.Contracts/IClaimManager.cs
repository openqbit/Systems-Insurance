using OpenQbit.Insurance.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.BusinessService.Contracts
{
    public interface IClaimManager : ICommonServiceManager
    {
        bool Record(AccidentValueEstimationModel ave,AgentModel agent,ClientModel client);
    }
}
