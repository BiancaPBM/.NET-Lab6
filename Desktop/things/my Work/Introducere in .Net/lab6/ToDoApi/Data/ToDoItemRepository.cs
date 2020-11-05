using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Entities;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public class ToDoItemRepository:IToDoItemRepository
    {
        private DatabaseContext _context;
        public ToDoItemRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Create(ToDoItem toDoItem)
        {
            var maxId = _context.ToDoItems.Max(p => p.Id);
            var newToDoItem = new Entities.ToDoItemDto()
            {
                Id = maxId + 1,
                Created = toDoItem.Created,
                Description = toDoItem.Description,
                IsDone = toDoItem.IsDone
            };
            _context.ToDoItems.Add(newToDoItem);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var toDoItemToBeDeleted = _context.ToDoItems.First(p => p.Id == id);
            if (toDoItemToBeDeleted == null)
            {
            }
            _context.ToDoItems.Remove(toDoItemToBeDeleted);
            _context.SaveChanges();
        }

        public IEnumerable<ToDoItemDto> GetAll()
        {
            return _context.ToDoItems.ToList();
        }

        public ToDoItemDto GetById(int id)
        {
            return _context.ToDoItems.FirstOrDefault(p => p.Id == id);
        }

        public void Update(ToDoItem toDoItem)
        {
            var maxId = _context.ToDoItems.Max(p => p.Id);
            var toDoItemDto = new ToDoItemDto()
            {
                Id = maxId + 1,
                Created = toDoItem.Created,
                Description = toDoItem.Description,
                IsDone = toDoItem.IsDone
            };
            _context.ToDoItems.Update(toDoItemDto);
            _context.SaveChanges();
        }
       
    }
}
