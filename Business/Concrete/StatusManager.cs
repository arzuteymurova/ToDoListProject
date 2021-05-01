using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StatusManager:IStatusService
    {
        IStatusDal _statusDal;

        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public List<Status> GetAll()
        {
           return _statusDal.GetAll();
        }

        [ValidationAspect(typeof(StatusValidator))]
        public void Add(Status status)
        {
           _statusDal.Add(status);
        }

        [ValidationAspect(typeof(StatusValidator))]
        public void Update(Status status)
        {
           _statusDal.Update(status);
        }

        
        public void Delete(Status status)
        {
            _statusDal.Delete(status);
        }
    }
}
