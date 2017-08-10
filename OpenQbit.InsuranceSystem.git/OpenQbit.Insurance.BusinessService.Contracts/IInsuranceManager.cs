using OpenQbit.Insurance.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.BusinessService.Contracts
{
    public interface IInsuranceManager : ICommonServiceManager
    {
        
        bool Record(InsuranceModel insurance,ClientModel client,PolicyCoverageDetailModel policyCoverage,DocumentModel document,CoverageModel coverage);
        ClientModel FindClientForInsurance(Expression<Func<ClientModel, bool>> predicate);
        DocumentModel GetDocumentForInsurance(Expression<Func<DocumentModel, bool>> predicate);
        PolicyCoverageDetailModel GetPolicyCoverageDetailForInsurance(Expression<Func<PolicyCoverageDetailModel, bool>> predicate);
        CoverageModel GetCoverageModelForInsurance(Expression<Func<CoverageModel, bool>> predicate);
    }
}
