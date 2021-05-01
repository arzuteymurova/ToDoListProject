using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class TaskDetailsDto:IDto
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public string Details { get; set; }
        public DateTime ReminderDate { get; set; }

    }
}
