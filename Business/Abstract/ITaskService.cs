using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;


namespace Business.Abstract
{
    public interface ITaskService
    {
        List<Task> GetAll();
        void Add(Task task);
        void Update(Task task);
        void Delete(Task task);
        List<TaskDetailsDto> GetTaskDetails();
        List<Task> GetByPriority(int priorityId);
        List<Task> GetByStatus(int statusId);
    }
}
