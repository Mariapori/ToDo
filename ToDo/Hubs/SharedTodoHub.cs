using Microsoft.AspNetCore.SignalR;
using ToDo.Data;
namespace ToDo.Hubs
{
    public class SharedTodoHub : Hub
    {
        public async void AddTodo(todo todo, int SharedTodoID)
        {
            await Clients.Others.SendAsync("UusiTodo", todo, SharedTodoID);
        }

        public async void RemTodo(todo todo, int SharedTodoID)
        {
            await Clients.Others.SendAsync("PoistaTodo", todo, SharedTodoID);
        }

        public async void UpdateTodo(todo todo, int SharedTodoID, Tila uusiTila)
        {
            await Clients.Others.SendAsync("PaivitaTodo", todo, SharedTodoID, uusiTila);
        }
    }
}
