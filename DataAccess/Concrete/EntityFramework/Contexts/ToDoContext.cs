using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework.Context
{
    public class ToDoContext:DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StatusMap());
          
        }

    }
}
