using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class TaskManager:ITaskService
    {
        ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public List<Task> GetAll()
        {
           return _taskDal.GetAll();
        }

        [ValidationAspect(typeof(TaskValidator))]
        public void Add(Task task)
        {
           _taskDal.Add(task);
        }

        [ValidationAspect(typeof(TaskValidator))]
        public void Update(Task task)
        {
            _taskDal.Update(task);
        }

      
        public void Delete(Task task)
        {
            _taskDal.Delete(task);
        }


        public List<TaskDetailsDto> GetTaskDetails()
        {
            return _taskDal.GetTaskDetails();
        }

        public List<Task> GetByPriority(int priorityId)
        {
            return _taskDal.GetAll(t=>t.PriorityId==priorityId);
        }

        public List<Task> GetByStatus(int statusId)
        {
            return _taskDal.GetAll(t=>t.StatusId==statusId);
        }
    }
}
