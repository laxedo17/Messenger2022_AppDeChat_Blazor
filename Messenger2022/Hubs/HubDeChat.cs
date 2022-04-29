using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Messenger2022.Hubs
{
    public class HubDeChat : Hub
    {
        public async Task EnviarMensaxe(string usuario, string mensaxe)
        {
            await Clients.All.SendAsync("RecibirMensaxe", usuario, mensaxe);
        }
    }
}