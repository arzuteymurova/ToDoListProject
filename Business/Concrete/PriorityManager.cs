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
    public class PriorityManager : IPriorityService
    {
        IPriorityDal _priorityDal;

        public PriorityManager(IPriorityDal priorityDal)
        {
            _priorityDal = priorityDal;
        }

        public List<Priority> GetAll()
        {
            return _priorityDal.GetAll();
        }

        [ValidationAspect(typeof(PriorityValidator))]
        public void Add(Priority priority)
        {
            _priorityDal.Add(priority);
        }

        [ValidationAspect(typeof(PriorityValidator))]
        public void Update(Priority priority)
        {
            _priorityDal.Update(priority);
        }

       
        public void Delete(Priority priority)
        {
           _priorityDal.Delete(priority);
        }

       
    }
}
