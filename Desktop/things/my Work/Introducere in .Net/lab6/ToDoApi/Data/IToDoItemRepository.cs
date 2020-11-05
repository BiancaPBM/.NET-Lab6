using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Entities;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public interface IToDoItemRepository
    {

        public IEnumerable<ToDoItemDto> GetAll();
        public ToDoItemDto GetById(int id);
        public void Create(ToDoItem product);
        public void Update(ToDoItem product);
        public void Delete(int id);
        
    }
}
