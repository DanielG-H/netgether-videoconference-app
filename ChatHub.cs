using Microsoft.AspNetCore.SignalR;
using VideoconferenceApp.Models;

namespace VideoconferenceApp
{
    public class ChatHub : Hub
    {
        public async Task SendComment(User user, Comment comment)
        {
            await Clients.All.SendAsync("ReceiveMessage", user.Username, comment.Text);
        }
    }
}
