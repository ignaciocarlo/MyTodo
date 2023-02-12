using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyTodo.Controller;
using MyTodo.Models;

namespace MyTodo.Pages;
public class TodoModel : PageModel
{
    [BindProperty]
    public Todo NewTodo { get; set; }
    public List<Todo> todos { get; set; }
    public string CompletedFreeText(Todo todo)
    {
        return todo.IsComepleted ? "Completed" : "Not Yet";
    }
    public void OnGet()
    {
        todos = MyTodoController.GetAll();
    }

}
  
