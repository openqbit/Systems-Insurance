using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Insurance.BusinessService.Contracts;
using OpenQbit.Insurance.DataAccess.DAL.Contracts;
using Microsoft.Practices.Unity;
using System.Linq.Expressions;
using OpenQbit.Insurance.Common.Models;

namespace OpenQbit.Insurance.BusinessService
{
    public class ClaimManager : IClaimManager
    {
        IRepository _repository;

        [InjectionConstructor]
        public ClaimManager(IRepository repository)
        {
            _repository = repository;
        }

        public bool Record<T>(T obj) where T : class
        {
            //Some Logics If Applicable
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

        public bool Record(AccidentValueEstimationModel ave, AgentModel agent, ClientModel client)
        {
            bool isAccidentValueAdded = _repository.Create(ave);
            if (isAccidentValueAdded)
            {
                return _repository.Save();
            }
            else
            {
                return false;
            }
        }
    }
}
