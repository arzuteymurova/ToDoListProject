using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ITaskDal:IEntityRepository<Task>
    {
        List<TaskDetailsDto> GetTaskDetails(Expression<Func<Task, bool>> filter = null);
    }
}
