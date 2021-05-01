using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            ToTable(@"Tasks");
            HasKey(t => t.Id);
            Property(t=>t.Id).HasColumnName("Id");
            Property(t=>t.TaskName).HasColumnName("TaskName");
            Property(t => t.StatusId).HasColumnName("StatusId");
            Property(t => t.PriorityId).HasColumnName("PriorityId");
            Property(t => t.DueDate).HasColumnName("DueDate");
            Property(t => t.Details).HasColumnName("Details");
            Property(t => t.ReminderDate).HasColumnName("ReminderDate");

        }
    }
}