using System.ComponentModel.DataAnnotations;

namespace MyTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public string Task { get; set; }
        public string Description { get; set; }
        public bool IsComepleted { get; set; }
        public TodoType Type { get; set; }
    }
    public enum TodoType
    {
        Personal,
        Productivity,
        Business
    }
}
