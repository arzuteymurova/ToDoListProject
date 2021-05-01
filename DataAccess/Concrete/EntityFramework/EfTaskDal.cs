using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal:EfEntityRepositoryBase<Task,ToDoContext>,ITaskDal
    {
        public List<TaskDetailsDto> GetTaskDetails(Expression<Func<Task, bool>> filter = null)
        {
            using(var context=new ToDoContext())
            {
                var result = from t in context.Tasks
                    join s in context.Statuses on t.StatusId equals s.StatusId
                    join p in context.Priorities on t.PriorityId equals p.PriorityId
                    select new TaskDetailsDto()
                    {
                        Id=t.Id,
                        Task = t.TaskName,
                        Status = s.StatusName,
                        Priority = p.PriorityName,
                        DueDate = t.DueDate,
                        Details = t.Details,
                        ReminderDate = t.ReminderDate
                    };
                return result.ToList();
            }
        }
    }
}
