using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoListWebApp.Services;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Pages
{
  public class IndexModel : PageModel
  {
    [BindProperty]
    public ToDo? NewToDo { get; set; }

    public List<ToDo> toDos = new();

    public void OnGet()
    {
      toDos = ToDoService.GetAll();
    }

    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
      {
        return Page();
      }
      ToDoService.Add(NewToDo!);
      return RedirectToAction("Get");
    }

    public IActionResult OnPostDelete(int id)
    {
      ToDoService.Delete(id);
      return RedirectToAction("Get");
    }
  }
}
