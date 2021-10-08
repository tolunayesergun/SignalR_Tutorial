using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Hubs;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IHubContext<Notification> _hubContext;

        public NotificationController(IHubContext<Notification> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> SendNotification (string message)
        {
            //await _hubContext.Clients.All.SendAsync("notify",message);
            await _hubContext.Clients.Group("5").SendAsync("notify", message);
            return Ok();
        }
    }
}
