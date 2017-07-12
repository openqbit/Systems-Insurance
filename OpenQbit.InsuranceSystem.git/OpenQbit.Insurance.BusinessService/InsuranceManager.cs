﻿using System;
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
        public bool Record(InsuranceModel insurance, ClientModel client)
        {
            throw new NotImplementedException();
        }


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
