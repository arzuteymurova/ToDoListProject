using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            ToTable(@"Statuses");
            HasKey(s => s.StatusId);
            Property(s => s.StatusId).HasColumnName("StatusId");
            Property(s=>s.StatusName).HasColumnName("StatusName");
           
        }
    }
}
