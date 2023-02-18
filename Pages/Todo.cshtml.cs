using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyTodo.Controller;
using MyTodo.Models;

namespace MyTodo.Pages;
public class TodoModel : PageModel
{
    [BindProperty]
    public Todo NewTodo { get; set; } = new();
    public List<Todo> todos { get; set; }
    public string CompletedFreeText(Todo todo)
    {
        return todo.IsComepleted ? "Completed" : "Not Yet";
    }
    public void OnGet()
    {
        todos = MyTodoController.GetAll();
    }
	public IActionResult OnPost()
	{
		if (!ModelState.IsValid)
		{
			return Page();
		}
		MyTodoController.Add(NewTodo);
		return RedirectToAction("Get");
	}
	public IActionResult OnPostDelete(int id)
	{
		MyTodoController.Delete(id);
		return RedirectToAction("Get");
	}
}
  
