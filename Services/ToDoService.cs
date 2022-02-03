using ToDoListWebApp.Models;

namespace ToDoListWebApp.Services
{
  public static class ToDoService
  {
    static List<ToDo> ToDos { get; }
    static int nextId = 3;
    static ToDoService()
    {
      ToDos = new List<ToDo>
                {
                    new ToDo { Id = 1, Title = "Learn C#", Priority = ToDoPriority.High },
                    new ToDo { Id = 1, Title = "Learn ASP.NET", Priority = ToDoPriority.Medium }
                };
    }

    public static List<ToDo> GetAll() => ToDos;

    public static ToDo? Get(int id) => ToDos.FirstOrDefault(p => p.Id == id);

    public static void Add(ToDo toDo)
    {
      toDo.Id = nextId++;
      ToDos.Add(toDo);
    }

    public static void Delete(int id)
    {
      var toDo = Get(id);
      if (toDo is null)
        return;

      ToDos.Remove(toDo);
    }
  }
}
