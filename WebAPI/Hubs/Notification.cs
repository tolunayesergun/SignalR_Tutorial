using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Hubs
{
    public class Notification : Hub
    {
        public async Task AddGroup(string groupId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId,groupId);
        }
    }
}
