using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Models
{
    public class ToDoItem
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Created { get; set; }
        public bool IsDone = false;
    }
}
