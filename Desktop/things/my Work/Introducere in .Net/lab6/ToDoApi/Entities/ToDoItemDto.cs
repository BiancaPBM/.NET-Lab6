using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Entities
{
    public class ToDoItemDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Created { get; set; }
        public bool IsDone = false;
    }
}
