using Microsoft.EntityFrameworkCore;
using ProductsApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Entities;

namespace ToDoApi.Data
{ 
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItemDto>().HasData(
                new ToDoItemDto
                {
                    Id = 1,
                    Description = "Gym",
                    IsDone = true,
                    Created = DateTime.Today,

                },
                 new ToDoItemDto
                 {
                     Id = 2,
                     Description = "Study",
                     Created = DateTime.Today,

                 },
                  new ToDoItemDto
                  {
                      Id = 3,
                      Description = "Work",
                      Created = DateTime.Today,

                  },
                   new ToDoItemDto
                   {
                       Id = 4,
                       Description = "Eat",
                       Created = DateTime.Today,

                   },
                    new ToDoItemDto
                    {
                        Id = 5,
                        Description = "Smile",
                        IsDone = true,
                        Created = DateTime.Today,

                    },
                     new ToDoItemDto
                     {
                         Id = 6,
                         Description = "Talk",
                         IsDone = true,
                         Created = DateTime.Today,

                     },
                      new ToDoItemDto
                      {
                          Id = 7,
                          Description = "Fork",
                          IsDone = false,
                          Created = DateTime.Today,

                      },
                       new ToDoItemDto
                       {
                           Id = 8,
                           Description = "Spoon",
                           IsDone = true,
                           Created = DateTime.Today,

                       }
            );

        }
    }
}
