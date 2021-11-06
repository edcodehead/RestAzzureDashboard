using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WellnessApp.Core;

namespace WellnessApp.DAL
{
    public class TodoService : ITodoService
    {
        //WellnessAppDbContext ServiceDbContext = new WellnessAppDbContext();

        private WellnessAppDbContext ServiceDbContext;

        public TodoService(WellnessAppDbContext dbContext)
        {
            ServiceDbContext = dbContext;
        }


        public List<TodoItem> GetTodoItems()
        {
            return ServiceDbContext.TodoItems.ToList();
        }
        public List<TodoItem> GetTodoItemsByStatus(TodoStatus status)
        {
            if (status == TodoStatus.NotComplete)
            {
                return ServiceDbContext.TodoItems.Where(thisTodo => thisTodo.IsComplete == false).ToList<TodoItem>();
            }
            else
            {
                return ServiceDbContext.TodoItems.Where(thisTodo => thisTodo.IsComplete == true).ToList<TodoItem>();
            }
        }
        public TodoItem GetTodoItem(int id)
        {
            return ServiceDbContext.TodoItems.Where(thisTodo => thisTodo.TodoItemID == id).FirstOrDefault();
        }
        public void AddTodoItem(TodoItem newItem)
        {
            this.ServiceDbContext.TodoItems.Add(newItem);
            this.ServiceDbContext.SaveChanges();
        }
        public void DeleteTodoItem(int id)
        {
            ServiceDbContext.TodoItems.Remove(GetTodoItem(id));
            ServiceDbContext.SaveChanges();
        }
        public void MarkTodoItemComplete(int id)
        {
            this.GetTodoItem(id).IsComplete = true;
            ServiceDbContext.SaveChanges();
        }
    }
}
