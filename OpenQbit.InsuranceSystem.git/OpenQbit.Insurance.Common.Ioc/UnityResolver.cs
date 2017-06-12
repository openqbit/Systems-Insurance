using Microsoft.Practices.Unity;
using OpenQbit.Insurance.DataAccess.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Insurance.DataAccess.DAL;
using OpenQbit.Insurance.BusinessService.Contracts;
using OpenQbit.Insurance.BusinessService;

namespace OpenQbit.Insurance.Common.Ioc
{
    public class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        private static void Register()
        {
            Container.RegisterType<IRepository, Repository>();

            Container.RegisterType<IAgentManager, AgentManager>();
            Container.RegisterType<IClientManager, ClientManager>();
            Container.RegisterType<IDocumentManager, DocumentManager>();
            Container.RegisterType<IInsuranceManager, InsuranceManager>();
            Container.RegisterType<IPolicyCoverageDetailManager, PolicyCoverageDetailManager>();
            //Container.RegisterType<IAccidentValueEstimationManager, AccidentValueEstimationManager>();
            //Container.RegisterType<IClaimManager, ClaimManager>();
            //Container.RegisterType<ICoverageManager, CoverageManager>();
            //Container.RegisterType<ICoverageManager, CoverageManager>();
            //Container.RegisterType<IEndorsementManager, EndorsementManager>();
            //Container.RegisterType<IItemManager, ItemManager>();
            //Container.RegisterType<IPaymentManager, PaymentManager>();
            //Container.RegisterType<IPolicyTypeManager, PolicyTypeManager>();

        }

        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = Container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }

        public static IUnityContainer GetContainer()
        {
            return Container;
        }
    }
}
