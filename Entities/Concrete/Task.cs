using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities;


namespace Entities.Concrete
{
    public class Task:IEntity
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public DateTime DueDate { get; set; }
        public string Details { get; set; }
        public DateTime ReminderDate { get; set; }
    }
}
