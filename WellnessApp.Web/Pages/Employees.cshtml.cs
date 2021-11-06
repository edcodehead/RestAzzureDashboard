using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WellnessApp.Core;
using WellnessApp.DAL;

namespace WellnessApp.Pages
{
    public class EmployeesModel : PageModel
    {
        ITodoService theTodoService;

        [BindProperty]
        public TodoItem TodoItems { get; set; }

        public List<TodoItem> todoList = new List<TodoItem>();

        public EmployeesModel(ITodoService tds)
        {
            theTodoService = tds;
        }

        public void OnGet()
        {
            todoList = theTodoService.GetTodoItems();
        }

        public IActionResult OnPost()
        {
            if (this.ModelState.IsValid)
            {
                theTodoService.AddTodoItem(TodoItems);
                return RedirectToPage("employees");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
