using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Entities;

namespace ToDoApi.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<ToDoItemDto> ToDoItems { get; set; }
    }
}
