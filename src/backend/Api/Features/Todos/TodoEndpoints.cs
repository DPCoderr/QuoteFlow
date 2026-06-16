using Api.Features.Todos.CreateTodo;
using Api.Features.Todos.ListTodos;

namespace Api.Features.Todos;

public static class TodoEndpoints
{
    public static RouteGroupBuilder MapTodosEndpoints(this RouteGroupBuilder app)
    {
        var group = app.MapGroup("/todos")
            .WithTags("Todos");

        group.MapListTodos();
        group.MapCreateTodo();

        return group;
    }
}
