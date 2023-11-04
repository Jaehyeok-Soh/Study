using ChatService.Model;
using Microsoft.AspNetCore.SignalR;

namespace ChatService.Hubs
{
    public class ChatHub : Hub
    {
        private readonly string _botUser;

        public ChatHub()
        {
            _botUser = "MyCheat Bot";
        }

        public async Task JoinRoom(UserConnection userConnection)
        {
            await Clients.All.SendAsync("ReceiveMessage", _botUser,
                $"{userConnection.User} has joined {userConnection.Room}");
        }
    }
}
