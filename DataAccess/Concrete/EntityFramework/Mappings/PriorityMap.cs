using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class PriorityMap : EntityTypeConfiguration<Priority>
    {
        public PriorityMap()
        {
            ToTable(@"Priorities");
            HasKey(p => p.PriorityId);
            Property(p => p.PriorityId).HasColumnName("PriorityId");
            Property(p => p.PriorityName).HasColumnName("PriorityName");
        }
    }
}