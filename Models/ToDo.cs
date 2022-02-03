using System.ComponentModel.DataAnnotations;

namespace ToDoListWebApp.Models
{
  public class ToDo
  {
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    public ToDoPriority Priority { get; set; }
  }

  public enum ToDoPriority { Low, Medium, High }
}
