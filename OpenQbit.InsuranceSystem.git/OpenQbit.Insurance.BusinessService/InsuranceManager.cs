using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Insurance.BusinessService.Contracts;
using OpenQbit.Insurance.DataAccess.DAL.Contracts;
using Microsoft.Practices.Unity;
using OpenQbit.Insurance.Common.Models;
using OpenQbit.Insurance.Common.Utils.Logs;
using OpenQbit.Insurance.BusinessService.Server_Side_Validators;

namespace OpenQbit.Insurance.BusinessService
{
    public class InsuranceManager : IInsuranceManager
    {
        IRepository _repository;
        ILogger _logger;

        [InjectionConstructor]
        public InsuranceManager(IRepository repository, ILogger logger)
        {
            this._repository = repository;
        }

        //Record Insurance
        public bool Record(InsuranceModel insurance, ClientModel client,PolicyCoverageDetailModel policyCoverage,DocumentModel document,CoverageModel coverage)
        {
            InsuranceModel.InsuranceTypes type = insurance.InsuranceType;
            switch (type)
            {
                case InsuranceModel.InsuranceTypes.MOTOR_INSURANCE:
                    return RecordNewMotorInsurance(insurance,client,policyCoverage,document,coverage);
                case InsuranceModel.InsuranceTypes.LIFE_INSURANCE:
                    return RecordNewLifeInsurance(insurance, client, policyCoverage, document, coverage);
                default:return false;                                      
            }
            //_repository.Create(InsuranceModel insurance, ClientModel client, PolicyCoverageDetailModel policyCoverage, DocumentModel document, CoverageModel coverage);
            throw new NotImplementedException();
        }

        //Business Logics for Life Insurance
        private bool RecordNewLifeInsurance(InsuranceModel insurance, ClientModel client, PolicyCoverageDetailModel policyCoverage, DocumentModel document, CoverageModel coverage)
        {
            ValidateAddInsurance validation = new ValidateAddInsurance();
            bool isCorrectAge = validation.ValidateForAge(client.Age);
            //_repository.Create(InsuranceModel insurance, ClientModel client, PolicyCoverageDetailModel policyCoverage, DocumentModel document, CoverageModel coverage);
            throw new NotImplementedException();
        }

        //Business Logics for Motor Insurance
        private bool RecordNewMotorInsurance(InsuranceModel insurance, ClientModel client, PolicyCoverageDetailModel policyCoverage, DocumentModel document, CoverageModel coverage)
        {
            
            ValidateAddInsurance validation = new ValidateAddInsurance();
            bool isCorrectAge = validation.ValidateForAge(client.Age);

            //_repository.Create(InsuranceModel insurance, ClientModel client, PolicyCoverageDetailModel policyCoverage, DocumentModel document, CoverageModel coverage);
            throw new NotImplementedException();
        }
        

        // Genric Methods Start from Here
        public bool Record<T>(T obj) where T : class
        {           
            return _repository.Create(obj);
        }
        
        public bool Delete<T>(T obj) where T : class
        {
            //Some Logics If Applicable
            return _repository.Delete(obj);
        }

        public T Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            //Some Logics If Applicable
            return _repository.Find(predicate);
        }

        public List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            //Some Logics If Applicable
            return _repository.FindList(predicate);
        }

        public List<T> GetAll<T>() where T : class
        {
            //Some Logics If Applicable
            return _repository.GetAll<T>();
        }


        public bool Update<T>(T obj) where T : class
        {
            //Some Logics If Applicable
            return _repository.Update(obj);
        }


        public bool Save()
        {
            return _repository.Save();
        }

        
    }
}
