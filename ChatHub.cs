using Microsoft.AspNetCore.SignalR;
using VideoconferenceApp.Models;

namespace VideoconferenceApp
{
    public class ChatHub : Hub
    {
        [HubMethodName("SendComment")]
        public async Task SendComment(int userId, string comment)
        {
            Comment message = new Comment
            {
                CommentId = 0,
                CreatedAt = DateTime.Now,
                CreatedBy = userId,
                Text = comment
            };

            await Clients.All.SendAsync("ReceiveComment", comment);
        }
    }
}
