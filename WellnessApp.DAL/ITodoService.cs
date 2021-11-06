using System;
using System.Collections.Generic;
using System.Text;
using WellnessApp.Core;

namespace WellnessApp.DAL
{
    public interface ITodoService
    {
        public List<TodoItem> GetTodoItems();
        public List<TodoItem> GetTodoItemsByStatus(TodoStatus status);
        public TodoItem GetTodoItem(int id);
        public void AddTodoItem(TodoItem newItem);
        public void DeleteTodoItem(int id);
        public void MarkTodoItemComplete(int id);
    }
}
