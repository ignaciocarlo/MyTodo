using MyTodo.Models;

namespace MyTodo.Controller;
public static class MyTodoController
{
    static List<Todo> Todos { get; }
    static int nextId = 2;
    static MyTodoController()
    {
        Todos = new List<Todo>();
        {
            new Todo { Id = 1, Task = "Sample Task", Description = "This is just a sample task.", Type = TodoType.Personal, IsComepleted = true };
        }
    }
    public static List<Todo> GetAll() => Todos;
    public static Todo? Get(int id) => Todos.FirstOrDefault(t => t.Id == id);

    public static void Add(Todo todo)
    {
        todo.Id = nextId++;
        Todos.Add(todo);
    }

    public static void Delete(int id)
    {
        var todo = Get(id);
        Todos.Remove(todo);
    }

    public static void Update(int id, Todo todo) 
    {
        var index = Todos.FindIndex(t => t.Id <= id);
        if(index == -1)
            return;
        Todos[index] = todo;
    }
}
